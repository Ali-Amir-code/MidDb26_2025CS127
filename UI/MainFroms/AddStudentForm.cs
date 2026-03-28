using MidDb26_2025CS127.BL;
using MidDb26_2025CS127.Models;
using System;
using System.Windows.Forms;
using MidDb26_2025CS127.Utilities;

namespace MidDb26_2025CS127.UI.Froms
{
    public enum FormMode { Add, Update };

    /// <summary>
    /// Dialog used for both adding a new student and editing an existing student.
    /// </summary>
    public partial class AddStudentForm : Form
    {
        public FormMode currentMode = FormMode.Add;
        public event EventHandler studentAdded;

        private int editingStudentId = -1;

        public AddStudentForm()
        {
            currentMode = FormMode.Add;
            InitializeComponent();
            SetupForm();
        }

        public AddStudentForm(Student student, string headerText, string btnText)
        {
            currentMode = FormMode.Update;
            InitializeComponent();
            SetupForm();

            editingStudentId = student.Id;
            titleLabel.Text = headerText;
            regNoTextBox.Text = student.RegistrationNo;
            firstNameTextBox.Text = student.FirstName;
            lastNameTextBox.Text = student.LastName ?? string.Empty;
            contactTextBox.Text = student.Contact ?? string.Empty;
            emailTextBox.Text = student.Email;

            if (student.DateOfBirth == null)
            {
                dateOfBirthInput.Checked = false;
            }
            else
            {
                dateOfBirthInput.Checked = true;
                dateOfBirthInput.Value = (DateTime)student.DateOfBirth;
            }

            if (student.Gender == null || student.Gender < 1)
            {
                genderComboBox.SelectedIndex = -1;
            }
            else
            {
                genderComboBox.SelectedIndex = student.Gender == 2 ? 1 : 0;
            }

            addBtn.Text = btnText;
        }

        private void SetupForm()
        {
            dateOfBirthInput.Checked = false;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (currentMode == FormMode.Add)
            {
                SaveStudent(isUpdate: false);
            }
            else if (currentMode == FormMode.Update)
            {
                SaveStudent(isUpdate: true);
            }
        }

        private void ClearForm()
        {
            regNoTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            contactTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            dateOfBirthInput.Checked = false;
            genderComboBox.SelectedIndex = -1;
        }

        private Student BuildStudentFromForm()
        {
            return new Student
            {
                Id = editingStudentId,
                RegistrationNo = regNoTextBox.Text,
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Contact = contactTextBox.Text,
                Email = emailTextBox.Text,
                DateOfBirth = dateOfBirthInput.Checked ? (DateTime?)dateOfBirthInput.Value.Date : null,
                Gender = genderComboBox.SelectedIndex
            };
        }

        private void SaveStudent(bool isUpdate)
        {
            ApplicationStatusService.PublishInfo(isUpdate ? "Updating student record..." : "Adding student record...");
            Student student = BuildStudentFromForm();

            string errorMessage;
            bool success = StudentBL.SaveStudent(student, isUpdate, out errorMessage);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show($"Error: {errorMessage}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!success)
            {
                MessageBox.Show("Unable to save student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApplicationStatusService.PublishSuccess(isUpdate ? "Student updated successfully." : "Student added successfully.");
            studentAdded?.Invoke(this, EventArgs.Empty);
            MessageBox.Show(isUpdate ? "Student updated successfully." : "Student added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
