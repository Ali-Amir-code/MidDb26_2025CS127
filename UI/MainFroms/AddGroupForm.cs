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

        private readonly List<Student> availableStudents = new List<Student>();
        private readonly List<Student> selectedStudents = new List<Student>();
        private readonly List<Project> projects = new List<Project>();

        private FormMode currentMode = FormMode.Add;
        private int editingGroupId = -1;
        private DateTime editingCreatedOn = DateTime.Now;

        public AddGroupForm()
        {
            currentMode = FormMode.Add;
            InitializeComponent();
            SetupForm();
        }

        public AddGroupForm(Group group, string title, string actionButtonText)
        {
            currentMode = FormMode.Update;
            InitializeComponent();
            SetupForm();

            editingGroupId = group.Id;
            editingCreatedOn = group.Created_On;
            titleLabel.Text = title;
            saveBtn.Text = actionButtonText;
            groupNameTextBox.Text = group.DisplayName;

            selectedStudents.Clear();
            selectedStudents.AddRange(group.Members ?? new List<Student>());

            LoadProjects(group.ProjectId);
            LoadStudents();
        }

        private void SetupForm()
        {
            selectedStudent1Panel.Visible = false;
            selectedStudent2Panel.Visible = false;

            unassignedStudentsList.DoubleClick += unassignedStudentsList_DoubleClick;
            saveBtn.Click += saveBtn_Click;
            cancelBtn.Click += cancelBtn_Click;

            if (currentMode == FormMode.Add)
            {
                LoadProjects(null);
                LoadStudents();
            }
        }

        private void LoadProjects(int? selectedProjectId)
        {
            projects.Clear();
            projects.Add(new Project { Id = 0, Title = "None" });
            projects.AddRange(GroupBL.GetProjectsForAssignment(currentMode == FormMode.Update ? (int?)editingGroupId : null));

            projectComboBox.DataSource = null;
            projectComboBox.DisplayMember = "Title";
            projectComboBox.ValueMember = "Id";
            projectComboBox.DataSource = projects;

            int selectedIndex = 0;
            if (selectedProjectId.HasValue)
            {
                int idx = projects.FindIndex(p => p.Id == selectedProjectId.Value);
                if (idx >= 0) selectedIndex = idx;
            }
            projectComboBox.SelectedIndex = selectedIndex;
        }

        private void LoadStudents()
        {
            availableStudents.Clear();
            availableStudents.AddRange(GroupBL.GetAvailableStudentsForGroup(currentMode == FormMode.Update ? (int?)editingGroupId : null));

            if (selectedStudents.Any())
            {
                availableStudents.RemoveAll(s => selectedStudents.Any(sel => sel.Id == s.Id));
            }

            BindAvailableStudents();
            RenderSelectedStudents();
        }

        private void BindAvailableStudents()
        {
            unassignedStudentsList.Items.Clear();
            foreach (var student in availableStudents)
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

            var selected = availableStudents[unassignedStudentsList.SelectedIndex];
            selectedStudents.Add(selected);
            availableStudents.RemoveAt(unassignedStudentsList.SelectedIndex);
            BindAvailableStudents();
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
            availableStudents.Add(student);
            availableStudents.Sort((a, b) => string.Compare(a.RegistrationNo, b.RegistrationNo, StringComparison.OrdinalIgnoreCase));

            BindAvailableStudents();
            RenderSelectedStudents();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var selectedProject = projectComboBox.SelectedItem as Project;
            var group = new Group
            {
                Id = editingGroupId,
                Created_On = currentMode == FormMode.Update ? editingCreatedOn : DateTime.Now,
                ProjectId = selectedProject != null && selectedProject.Id > 0 ? (int?)selectedProject.Id : null,
                Members = selectedStudents.ToList()
            };

            string errorMessage;
            bool success = GroupBL.SaveGroup(group, currentMode == FormMode.Update, out errorMessage);

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

            ApplicationStatusService.PublishSuccess(currentMode == FormMode.Update ? "Group updated successfully." : "Group created successfully.");
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
