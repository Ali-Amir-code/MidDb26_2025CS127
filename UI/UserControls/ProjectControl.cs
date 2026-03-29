using MidDb26_2025CS127.BL;
using MidDb26_2025CS127.Models;
using MidDb26_2025CS127.UI.Froms;
using MidDb26_2025CS127.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MidDb26_2025CS127.UI.UserControls
{
    public partial class ProjectControl : UserControl
    {
        private const string HiddenIdColumnName = "projectIdHiddenColumn";

        private List<Project> projects = new List<Project>();
        private ComboBox advisorFilterComboBox;

        public ProjectControl(List<Project> projects)
        {
            InitializeComponent();
            EnsureHiddenIdColumn();
            BuildAdvisorFilterControl();

            this.projects = projects ?? new List<Project>();
            LoadProjects(this.projects);
            LoadAdvisorFilter();
            ApplicationStatusService.PublishSuccess("Project records loaded.");

            deleteProjectsBtn.Click += deleteProjectsBtn_Click;
            selectBtn.Click += selectBtn_Click;
            clearBtn.Click += clearBtn_Click;
            sortComboBox.SelectedIndexChanged += sortComboBox_SelectedIndexChanged;
            projectListGrid.CellDoubleClick += projectListGrid_CellDoubleClick;
        }

        private void BuildAdvisorFilterControl()
        {
            advisorFilterComboBox = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Popup,
                Location = new Point(11, 155),
                Size = new Size(225, 24)
            };
            var advisorLabel = new Label
            {
                Text = "ADVISOR:",
                Location = new Point(8, 136),
                AutoSize = true,
                Font = new Font("Segoe UI", 7.8F, FontStyle.Bold)
            };
            formPanel.Controls.Add(advisorLabel);
            formPanel.Controls.Add(advisorFilterComboBox);

            clearBtn.Location = new Point(122, 188);
            selectBtn.Location = new Point(11, 188);
        }

        private void LoadAdvisorFilter()
        {
            advisorFilterComboBox.Items.Clear();
            advisorFilterComboBox.Items.Add("All");
            foreach (var name in projects.Select(p => p.AdvisorName).Where(n => !string.IsNullOrWhiteSpace(n)).Distinct().OrderBy(x => x))
            {
                advisorFilterComboBox.Items.Add(name);
            }
            advisorFilterComboBox.SelectedIndex = 0;
        }

        private void EnsureHiddenIdColumn()
        {
            if (projectListGrid.Columns.Contains(HiddenIdColumnName)) return;
            projectListGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = HiddenIdColumnName, Visible = false });
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
            LoadAdvisorFilter();
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

        private void Form_projectAdded(object sender, EventArgs e) => RefreshData();

        private void deleteProjectsBtn_Click(object sender, EventArgs e)
        {
            if (projectListGrid.Rows.Count == 0)
            {
                MessageBox.Show("Select a project to delete.", "Delete Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Delete all currently listed projects?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            var ids = projectListGrid.Rows.Cast<DataGridViewRow>().Where(r => r.Cells[HiddenIdColumnName].Value != null).Select(r => Convert.ToInt32(r.Cells[HiddenIdColumnName].Value)).Distinct().ToList();
            ProjectBL.DeleteProjects(ids);
            RefreshData();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            string title = regNoTextBox.Text.Trim();
            string description = firstNameTextBox.Text.Trim();
            string advisorName = advisorFilterComboBox.SelectedItem != null ? advisorFilterComboBox.SelectedItem.ToString() : "All";

            bool hasAnyCriteria = !string.IsNullOrWhiteSpace(title) || !string.IsNullOrWhiteSpace(description) || !advisorName.Equals("All", StringComparison.OrdinalIgnoreCase);
            if (!hasAnyCriteria)
            {
                LoadProjects(projects);
                return;
            }

            var filtered = ProjectBL.FilterProjects(projects, title, description, advisorName);
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
            advisorFilterComboBox.SelectedIndex = 0;
            LoadProjects(projects);
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortComboBox.SelectedItem == null) return;
            if (sortComboBox.SelectedItem.ToString().Equals("Title", StringComparison.OrdinalIgnoreCase)) LoadProjects(projects.OrderBy(p => p.Title).ToList());
        }

        private void projectListGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = projectListGrid.Rows[e.RowIndex];
            if (row.Cells[HiddenIdColumnName].Value == null) return;

            int projectId = Convert.ToInt32(row.Cells[HiddenIdColumnName].Value);
            var project = projects.FirstOrDefault(p => p.Id == projectId);
            if (project == null) return;

            using (var form = new AddProjectForm(project, "Edit Project", "Update"))
            {
                form.projectAdded += Form_projectAdded;
                form.ShowDialog();
            }
        }

        private void coAdvisorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainAdvisorLabel_Click(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void mainAdvisorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
