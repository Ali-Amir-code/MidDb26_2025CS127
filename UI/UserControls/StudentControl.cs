using MidDb26_2025CS127.BL;
using MidDb26_2025CS127.Models;
using MidDb26_2025CS127.UI.Froms;
using MidDb26_2025CS127.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MidDb26_2025CS127.UI.UserControls
{
    
    public partial class StudentControl : UserControl
    {
        private List<Student> students = new List<Student>();

        public StudentControl(List<Student> students)
        {
            InitializeComponent();
            this.students = students ?? new List<Student>();
            LoadStudents(this.students);
            ApplicationStatusService.PublishSuccess("Student records loaded.");
            selectBtn.Click += selectBtn_Click;
            clearBtn.Click += clearBtn_Click;
            deleteStudentBtn.Click += deleteStudentBtn_Click;
        }

        private void LoadStudents(List<Student> studentItems)
        {
            students = studentItems ?? new List<Student>();
            studentListGrid.Rows.Clear();

            foreach (var item in students)
            {
                studentListGrid.Rows.Add(item.Id, item.RegistrationNo, item.FirstName, item.LastName, item.Contact, item.Email, item.DateOfBirth.HasValue ? item.DateOfBirth.Value.ToShortDateString() : string.Empty, item.Gender.HasValue ? (item.Gender.Value == 1 ? "Male" : "Female" ) : string.Empty);
            }
        }

        private void RefreshData()
        {
            ApplicationStatusService.PublishInfo("Refreshing student data...");
            LoadStudents(StudentBL.GetAllStudents());
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            // Collect UI inputs
            string registrationNo = regNoTextBox.Text.Trim();
            string firstName = firstNameTextBox.Text.Trim();
            string lastName = lastNameTextBox.Text.Trim();
            string contact = contactTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string genderText = genderComboBox.SelectedItem != null ? genderComboBox.SelectedItem.ToString() : string.Empty;
            bool dobChecked = dobPicker != null && dobPicker.Checked;
            DateTime? dob = dobChecked ? (DateTime?)dobPicker.Value.Date : null;

            bool hasAnyCriteria = !string.IsNullOrWhiteSpace(registrationNo)
                                  || !string.IsNullOrWhiteSpace(firstName)
                                  || !string.IsNullOrWhiteSpace(lastName)
                                  || !string.IsNullOrWhiteSpace(contact)
                                  || !string.IsNullOrWhiteSpace(email)
                                  || ( !string.IsNullOrWhiteSpace(genderText) && !genderText.Equals("All", StringComparison.OrdinalIgnoreCase) )
                                  || dobChecked;

            if (!hasAnyCriteria)
            {
                LoadStudents(students);
                if (dobPicker != null) dobPicker.Checked = false;
                return;
            }

            int? genderVal = null;
            if (!string.IsNullOrWhiteSpace(genderText) && !genderText.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                if (genderText.Equals("Male", StringComparison.OrdinalIgnoreCase)) genderVal = 1;
                else if (genderText.Equals("Female", StringComparison.OrdinalIgnoreCase)) genderVal = 2;
            }

            var filtered = StudentBL.FilterStudents(students, registrationNo, firstName, lastName, contact, email, genderVal, dob);

            if (!filtered.Any())
            {
                MessageBox.Show("No student found matching provided criteria.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dobPicker != null) dobPicker.Checked = false;
                return;
            }

            if (dobPicker != null) dobPicker.Checked = false;

            LoadStudents(filtered);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            regNoTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            contactTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            genderComboBox.SelectedIndex = -1;
            dobPicker.Checked = false;
            LoadStudents(students);
        }

        private void deleteStudentBtn_Click(object sender, EventArgs e)
        {
            if (studentListGrid.Rows.Count == 0)
            {
                MessageBox.Show("Select a student to delete.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Delete all currently listed students?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            var ids = studentListGrid.Rows
                .Cast<DataGridViewRow>()
                .Where(row => row.Cells["idColumn"].Value != null)
                .Select(row => Convert.ToInt32(row.Cells["idColumn"].Value))
                .Distinct()
                .ToList();

            StudentBL.DeleteStudents(ids);
            RefreshData();
        }

        private void saperator_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gridContainer_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            ApplicationStatusService.PublishInfo("Opening Add Student dialog...");
            using (var form = new AddStudentForm())
            {
                form.studentAdded += AddStudentForm_studentAdded;
                form.ShowDialog();
            }
        }

        private void AddStudentForm_studentAdded(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void studentListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (studentListGrid.Columns[e.ColumnIndex].Name == "editColumn")
            {
                var row = studentListGrid.Rows[e.RowIndex];
                Student student = new Student
                {
                    Id = int.Parse(Convert.ToString(row.Cells["idColumn"].Value)),
                    RegistrationNo = Convert.ToString(row.Cells["regColumn"].Value),
                    FirstName = Convert.ToString(row.Cells["firstNameColumn"].Value),
                    LastName = Convert.ToString(row.Cells["lastNameColumn"].Value),
                    Contact = Convert.ToString(row.Cells["contactColumn"].Value),
                    Email = Convert.ToString(row.Cells["emailColumn"].Value),
                    DateOfBirth = string.IsNullOrWhiteSpace(Convert.ToString(row.Cells["dobColumn"].Value)) ? (DateTime?)null : DateTime.Parse(Convert.ToString(row.Cells["dobColumn"].Value)),
                    Gender = string.IsNullOrWhiteSpace(Convert.ToString(row.Cells["genderColumn"].Value)) ? (int?)null : int.Parse(Convert.ToString(row.Cells["genderColumn"].Value))
                };

                using (var form = new AddStudentForm(student, "Edit Student", "Update"))
                {
                    form.studentAdded += AddStudentForm_studentAdded;
                    form.ShowDialog();
                }
            }
            else if (studentListGrid.Columns[e.ColumnIndex].Name == "deleteColumn")
            {
                int studentId = Convert.ToInt32(studentListGrid.Rows[e.RowIndex].Cells["idColumn"].Value);
                if (MessageBox.Show("Delete selected student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    StudentBL.DeleteStudent(studentId);
                    RefreshData();
                }
            }
        }

    }
}
