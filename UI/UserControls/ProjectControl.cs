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
    public partial class ProjectControl : UserControl
    {
        private const string HiddenIdColumnName = "projectIdHiddenColumn";

        private List<Project> projects = new List<Project>();

        public ProjectControl(List<Project> projects)
        {
            InitializeComponent();
            EnsureHiddenIdColumn();

            this.projects = projects ?? new List<Project>();
            LoadProjects(this.projects);
            ApplicationStatusService.PublishSuccess("Project records loaded.");

            deleteProjectsBtn.Click += deleteProjectsBtn_Click;
            selectBtn.Click += selectBtn_Click;
            clearBtn.Click += clearBtn_Click;
            sortComboBox.SelectedIndexChanged += sortComboBox_SelectedIndexChanged;
            projectListGrid.CellDoubleClick += projectListGrid_CellDoubleClick;
        }

        private void EnsureHiddenIdColumn()
        {
            if (projectListGrid.Columns.Contains(HiddenIdColumnName))
            {
                return;
            }

            var hiddenColumn = new DataGridViewTextBoxColumn
            {
                Name = HiddenIdColumnName,
                Visible = false
            };
            projectListGrid.Columns.Add(hiddenColumn);
        }

        private void LoadProjects(List<Project> projectItems)
        {
            projects = projectItems ?? new List<Project>();
            projectListGrid.Rows.Clear();

            foreach (var item in projects)
            {
                int index = projectListGrid.Rows.Add(item.Title, item.AssignedGroupCount > 0 ? item.AssignedGroupName : string.Empty, item.Description);
                projectListGrid.Rows[index].Cells[HiddenIdColumnName].Value = item.Id;
            }
        }

        private void RefreshData()
        {
            ApplicationStatusService.PublishInfo("Refreshing project data...");
            LoadProjects(ProjectBL.GetAllProjects());
        }

        private void addProjectBtn_Click(object sender, EventArgs e)
        {
            ApplicationStatusService.PublishInfo("Opening Add Project dialog...");
            using (var form = new AddProjectForm())
            {
                form.projectAdded += Form_projectAdded;
                form.ShowDialog();
            }
        }

        private void Form_projectAdded(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void deleteProjectsBtn_Click(object sender, EventArgs e)
        {
            if (projectListGrid.Rows.Count == 0)
            {
                MessageBox.Show("Select a project to delete.", "Delete Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Delete all currently listed projects?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            var ids = projectListGrid.Rows
                .Cast<DataGridViewRow>()
                .Where(row => row.Cells[HiddenIdColumnName].Value != null)
                .Select(row => Convert.ToInt32(row.Cells[HiddenIdColumnName].Value))
                .Distinct()
                .ToList();

            ProjectBL.DeleteProjects(ids);
            RefreshData();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            string title = regNoTextBox.Text.Trim();
            string description = firstNameTextBox.Text.Trim();

            bool hasAnyCriteria = !string.IsNullOrWhiteSpace(title) || !string.IsNullOrWhiteSpace(description);
            if (!hasAnyCriteria)
            {
                LoadProjects(projects);
                return;
            }

            var filtered = ProjectBL.FilterProjects(projects, title, description);
            if (!filtered.Any())
            {
                MessageBox.Show("No project found matching provided criteria.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            LoadProjects(filtered);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            regNoTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            LoadProjects(projects);
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortComboBox.SelectedItem == null)
            {
                return;
            }

            var selected = sortComboBox.SelectedItem.ToString();
            if (selected.Equals("Title", StringComparison.OrdinalIgnoreCase))
            {
                LoadProjects(projects.OrderBy(p => p.Title).ToList());
            }
        }

        private void projectListGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var row = projectListGrid.Rows[e.RowIndex];
            if (row.Cells[HiddenIdColumnName].Value == null)
            {
                return;
            }

            int projectId = Convert.ToInt32(row.Cells[HiddenIdColumnName].Value);
            var project = projects.FirstOrDefault(p => p.Id == projectId);
            if (project == null)
            {
                return;
            }

            using (var form = new AddProjectForm(project, "Edit Project", "Update"))
            {
                form.projectAdded += Form_projectAdded;
                form.ShowDialog();
            }
        }
    }
}
