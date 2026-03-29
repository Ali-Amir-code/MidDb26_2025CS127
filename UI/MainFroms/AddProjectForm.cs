using MidDb26_2025CS127.BL;
using MidDb26_2025CS127.Models;
using MidDb26_2025CS127.Utilities;
using System;
using System.Windows.Forms;

namespace MidDb26_2025CS127.UI.Froms
{
    public partial class AddProjectForm : Form
    {
        public FormMode currentMode = FormMode.Add;
        public event EventHandler projectAdded;

        private int editingProjectId = -1;

        public AddProjectForm()
        {
            currentMode = FormMode.Add;
            InitializeComponent();
            SetupForm();
        }

        public AddProjectForm(Project project, string headerText, string btnText)
        {
            currentMode = FormMode.Update;
            InitializeComponent();
            SetupForm();

            editingProjectId = project.Id;
            titleLabel.Text = headerText;
            regNoTextBox.Text = project.Title;
            firstNameTextBox.Text = project.Description ?? string.Empty;
            addBtn.Text = btnText;
        }

        private void SetupForm()
        {
            addBtn.Click += addBtn_Click;
            clearBtn.Click += clearBtn_Click;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            regNoTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SaveProject(currentMode == FormMode.Update);
        }

        private Project BuildProjectFromForm()
        {
            return new Project
            {
                Id = editingProjectId,
                Title = regNoTextBox.Text,
                Description = firstNameTextBox.Text
            };
        }

        private void SaveProject(bool isUpdate)
        {
            ApplicationStatusService.PublishInfo(isUpdate ? "Updating project record..." : "Adding project record...");
            var project = BuildProjectFromForm();

            string errorMessage;
            bool success = ProjectBL.SaveProject(project, isUpdate, out errorMessage);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show($"Error: {errorMessage}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!success)
            {
                MessageBox.Show("Unable to save project.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApplicationStatusService.PublishSuccess(isUpdate ? "Project updated successfully." : "Project added successfully.");
            projectAdded?.Invoke(this, EventArgs.Empty);
            MessageBox.Show(isUpdate ? "Project updated successfully." : "Project added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void regLabel_Click(object sender, EventArgs e)
        {
        }
    }
}
