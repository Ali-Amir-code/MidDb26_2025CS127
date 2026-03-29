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
    public partial class AddProjectForm : Form
    {
        public FormMode currentMode = FormMode.Add;
        public event EventHandler projectAdded;

        private int editingProjectId = -1;

        private ComboBox mainAdvisorComboBox;
        private ComboBox coAdvisorComboBox;
        private ComboBox industryAdvisorComboBox;
        private List<Advisor> advisors = new List<Advisor>();

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

            SelectAdvisor(mainAdvisorComboBox, project.MainAdvisorId);
            SelectAdvisor(coAdvisorComboBox, project.CoAdvisorId);
            SelectAdvisor(industryAdvisorComboBox, project.IndustryAdvisorId);
        }

        private void SetupForm()
        {
            BuildAdvisorControls();
            LoadAdvisorData();
            addBtn.Click += addBtn_Click;
            clearBtn.Click += clearBtn_Click;
        }

        private void BuildAdvisorControls()
        {
            mainAdvisorComboBox = CreateAdvisorCombo(210);
            coAdvisorComboBox = CreateAdvisorCombo(245);
            industryAdvisorComboBox = CreateAdvisorCombo(280);

            mainPanel.Controls.Add(CreateAdvisorLabel("MAIN ADVISOR:", 68, 210));
            mainPanel.Controls.Add(CreateAdvisorLabel("CO ADVISOR:", 85, 245));
            mainPanel.Controls.Add(CreateAdvisorLabel("INDUSTRY ADVISOR:", 35, 280));
            mainPanel.Controls.Add(mainAdvisorComboBox);
            mainPanel.Controls.Add(coAdvisorComboBox);
            mainPanel.Controls.Add(industryAdvisorComboBox);
        }

        private ComboBox CreateAdvisorCombo(int y)
        {
            return new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Popup,
                Location = new Point(168, y),
                Size = new Size(227, 24)
            };
        }

        private Label CreateAdvisorLabel(string text, int x, int y)
        {
            return new Label
            {
                Text = text,
                Location = new Point(x, y),
                AutoSize = true,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
        }

        private void LoadAdvisorData()
        {
            advisors = ProjectBL.GetAdvisorOptions();
            BindAdvisorCombo(mainAdvisorComboBox);
            BindAdvisorCombo(coAdvisorComboBox);
            BindAdvisorCombo(industryAdvisorComboBox);
        }

        private void BindAdvisorCombo(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("None");
            foreach (var advisor in advisors)
            {
                combo.Items.Add($"{advisor.FirstName} {advisor.LastName}".Trim());
            }
            combo.SelectedIndex = 0;
        }

        private void SelectAdvisor(ComboBox combo, int? advisorId)
        {
            if (!advisorId.HasValue)
            {
                combo.SelectedIndex = 0;
                return;
            }

            int index = advisors.FindIndex(a => a.Id == advisorId.Value);
            combo.SelectedIndex = index >= 0 ? index + 1 : 0;
        }

        private int? GetSelectedAdvisorId(ComboBox combo)
        {
            int advisorIndex = combo.SelectedIndex - 1;
            if (advisorIndex < 0 || advisorIndex >= advisors.Count) return null;
            return advisors[advisorIndex].Id;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            regNoTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            mainAdvisorComboBox.SelectedIndex = 0;
            coAdvisorComboBox.SelectedIndex = 0;
            industryAdvisorComboBox.SelectedIndex = 0;
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
                Description = firstNameTextBox.Text,
                MainAdvisorId = GetSelectedAdvisorId(mainAdvisorComboBox),
                CoAdvisorId = GetSelectedAdvisorId(coAdvisorComboBox),
                IndustryAdvisorId = GetSelectedAdvisorId(industryAdvisorComboBox)
            };
        }

        private void SaveProject(bool isUpdate)
        {
        }

        private void SetupForm()
        {
            BuildAdvisorControls();
            LoadAdvisorData();
            addBtn.Click += addBtn_Click;
            clearBtn.Click += clearBtn_Click;
        }

        private void BuildAdvisorControls()
        {
            advisorComboBox = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Popup,
                Location = new Point(168, 210),
                Size = new Size(227, 24)
            };
            advisorRoleComboBox = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Popup,
                Location = new Point(168, 245),
                Size = new Size(227, 24)
            };

            var advisorLabel = new Label
            {
                Text = "ADVISOR:",
                Location = new Point(98, 210),
                AutoSize = true,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
            var roleLabel = new Label
            {
                Text = "ADVISOR ROLE:",
                Location = new Point(53, 245),
                AutoSize = true,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };

            mainPanel.Controls.Add(advisorLabel);
            mainPanel.Controls.Add(roleLabel);
            mainPanel.Controls.Add(advisorComboBox);
            mainPanel.Controls.Add(advisorRoleComboBox);
        }

        private void LoadAdvisorData()
        {
            advisors = ProjectBL.GetAdvisorOptions();
            advisorComboBox.Items.Clear();
            advisorComboBox.Items.Add("None");
            foreach (var advisor in advisors)
            {
                advisorComboBox.Items.Add($"{advisor.FirstName} {advisor.LastName}".Trim());
            }
            advisorComboBox.SelectedIndex = 0;

            advisorRoles = ProjectBL.GetAdvisorRoleOptions();
            advisorRoleComboBox.Items.Clear();
            advisorRoleComboBox.Items.Add("Default");
            foreach (var role in advisorRoles) advisorRoleComboBox.Items.Add(role.Value);
            advisorRoleComboBox.SelectedIndex = 0;
        }

        private void SelectAdvisor(int? advisorId)
        {
            if (!advisorId.HasValue)
            {
                advisorComboBox.SelectedIndex = 0;
                return;
            }

            int index = advisors.FindIndex(a => a.Id == advisorId.Value);
            advisorComboBox.SelectedIndex = index >= 0 ? index + 1 : 0;
        }

        private void SelectAdvisorRole(int? roleId)
        {
            if (!roleId.HasValue)
            {
                advisorRoleComboBox.SelectedIndex = 0;
                return;
            }

            int index = advisorRoles.FindIndex(r => r.Id == roleId.Value);
            advisorRoleComboBox.SelectedIndex = index >= 0 ? index + 1 : 0;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            regNoTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            advisorComboBox.SelectedIndex = 0;
            advisorRoleComboBox.SelectedIndex = 0;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SaveProject(currentMode == FormMode.Update);
        }

        private Project BuildProjectFromForm()
        {
            int advisorIndex = advisorComboBox.SelectedIndex - 1;
            int roleIndex = advisorRoleComboBox.SelectedIndex - 1;
            return new Project
            {
                Id = editingProjectId,
                Title = regNoTextBox.Text,
                Description = firstNameTextBox.Text,
                AdvisorId = advisorIndex >= 0 && advisorIndex < advisors.Count ? (int?)advisors[advisorIndex].Id : null,
                AdvisorRoleId = roleIndex >= 0 && roleIndex < advisorRoles.Count ? (int?)advisorRoles[roleIndex].Id : null
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

        private void regLabel_Click(object sender, EventArgs e) { }
    }
}
