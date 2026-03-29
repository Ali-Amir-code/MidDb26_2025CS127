using MidDb26_2025CS127.BL;
using MidDb26_2025CS127.Models;
using MidDb26_2025CS127.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MidDb26_2025CS127.UI.Froms
{
    public partial class AddGroupForm : Form
    {
        public event EventHandler groupSaved;

        private readonly List<Student> unassignedStudents = new List<Student>();
        private readonly List<Student> selectedStudents = new List<Student>();
        private readonly List<Project> projects = new List<Project>();

        public AddGroupForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            selectedStudent1Panel.Visible = false;
            selectedStudent2Panel.Visible = false;

            unassignedStudentsList.DoubleClick += unassignedStudentsList_DoubleClick;
            saveBtn.Click += saveBtn_Click;
            cancelBtn.Click += cancelBtn_Click;

            LoadProjects();
            LoadStudents();
        }

        private void LoadProjects()
        {
            projects.Clear();
            projects.AddRange(GroupBL.GetProjectsForAssignment());

            projectComboBox.DataSource = null;
            projectComboBox.DisplayMember = "Title";
            projectComboBox.ValueMember = "Id";
            projectComboBox.DataSource = projects;
            projectComboBox.SelectedIndex = -1;
        }

        private void LoadStudents()
        {
            unassignedStudents.Clear();
            unassignedStudents.AddRange(GroupBL.GetUnassignedStudents());
            BindUnassignedStudents();
            RenderSelectedStudents();
        }

        private void BindUnassignedStudents()
        {
            unassignedStudentsList.Items.Clear();
            foreach (var student in unassignedStudents)
            {
                unassignedStudentsList.Items.Add(CreateStudentDisplay(student));
            }
        }

        private static string CreateStudentDisplay(Student student)
        {
            return $"{student.RegistrationNo} - {student.FirstName} {student.LastName}".Trim();
        }

        private void unassignedStudentsList_DoubleClick(object sender, EventArgs e)
        {
            if (unassignedStudentsList.SelectedIndex < 0)
            {
                return;
            }

            var selected = unassignedStudents[unassignedStudentsList.SelectedIndex];
            selectedStudents.Add(selected);
            unassignedStudents.RemoveAt(unassignedStudentsList.SelectedIndex);
            BindUnassignedStudents();
            RenderSelectedStudents();
        }

        private void RenderSelectedStudents()
        {
            selectedStudentPanel.Controls.Clear();
            int y = 5;

            foreach (var student in selectedStudents)
            {
                var panel = new Panel
                {
                    Width = selectedStudentPanel.Width - 20,
                    Height = 40,
                    Location = new Point(4, y)
                };

                var label = new Label
                {
                    AutoSize = false,
                    Width = 220,
                    Height = 24,
                    Location = new Point(4, 8),
                    Text = CreateStudentDisplay(student),
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold)
                };

                var removeBtn = new Button
                {
                    Width = 78,
                    Height = 30,
                    Location = new Point(panel.Width - 84, 5),
                    Text = "Remove",
                    BackColor = Color.FromArgb(239, 68, 68),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Tag = student.Id
                };
                removeBtn.Click += removeStudentBtn_Click;

                panel.Controls.Add(label);
                panel.Controls.Add(removeBtn);
                selectedStudentPanel.Controls.Add(panel);
                y += 44;
            }
        }

        private void removeStudentBtn_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null)
            {
                return;
            }

            int studentId = Convert.ToInt32(btn.Tag);
            var student = selectedStudents.FirstOrDefault(s => s.Id == studentId);
            if (student == null)
            {
                return;
            }

            selectedStudents.Remove(student);
            unassignedStudents.Add(student);
            unassignedStudents.Sort((a, b) => string.Compare(a.RegistrationNo, b.RegistrationNo, StringComparison.OrdinalIgnoreCase));

            BindUnassignedStudents();
            RenderSelectedStudents();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var selectedProject = projectComboBox.SelectedItem as Project;
            var group = new Group
            {
                Created_On = DateTime.Now,
                ProjectId = selectedProject != null ? (int?)selectedProject.Id : null,
                Members = selectedStudents.ToList()
            };

            string errorMessage;
            bool success = GroupBL.SaveGroup(group, out errorMessage);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!success)
            {
                MessageBox.Show("Unable to save group.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApplicationStatusService.PublishSuccess("Group created successfully.");
            groupSaved?.Invoke(this, EventArgs.Empty);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void unassignedStudentsLabel_Click(object sender, EventArgs e) { }
        private void titleLabel_Click(object sender, EventArgs e) { }
        private void selectedStudent1RemoveBtn_Click(object sender, EventArgs e) { }
    }
}
