using MidDb26_2025CS127.BL;
using MidDb26_2025CS127.Models;
using MidDb26_2025CS127.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MidDb26_2025CS127.UI.Froms
{
    public partial class AddAdvisorForm : Form
    {
        public FormMode currentMode = FormMode.Add;
        public event EventHandler advisorAdded;

        private int editingAdvisorId = -1;
        private List<Lookup> designationLookups = new List<Lookup>();

        public AddAdvisorForm()
        {
            currentMode = FormMode.Add;
            InitializeComponent();
            SetupForm();
        }

        public AddAdvisorForm(Advisor advisor, string headerText, string btnText)
        {
            currentMode = FormMode.Update;
            InitializeComponent();
            SetupForm();

            editingAdvisorId = advisor.Id;
            titleLabel.Text = headerText;
            firstNameTextBox.Text = advisor.FirstName;
            lastNameTextBox.Text = advisor.LastName ?? string.Empty;
            contactTextBox.Text = advisor.Contact ?? string.Empty;
            emailTextBox.Text = advisor.Email;
            salaryTextBox.Text = advisor.Salary.HasValue ? advisor.Salary.Value.ToString("0.##") : string.Empty;
            textBox2.Text = !string.IsNullOrWhiteSpace(advisor.DesignationLabel)
                ? advisor.DesignationLabel
                : ResolveDesignationText(advisor.Designation);

            if (advisor.DateOfBirth == null)
            {
                dateTimePicker1.Checked = false;
            }
            else
            {
                dateTimePicker1.Checked = true;
                dateTimePicker1.Value = advisor.DateOfBirth.Value;
            }

            if (advisor.Gender == null || advisor.Gender < 1)
            {
                genderComboBox.SelectedIndex = -1;
            }
            else
            {
                genderComboBox.SelectedIndex = advisor.Gender == 2 ? 1 : 0;
            }

            addBtn.Text = btnText;
        }

        private void SetupForm()
        {
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.Checked = false;
            addBtn.Click += addBtn_Click;
            clearBtn.Click += clearBtn_Click;
            LoadDesignationOptions();
        }

        private void LoadDesignationOptions()
        {
            designationLookups = AdvisorBL.GetDesignationLookups() ?? new List<Lookup>();

            designationComboBox.Items.Clear();
            designationComboBox.DisplayMember = "Value";
            designationComboBox.ValueMember = "Id";
            designationComboBox.DataSource = designationLookups;
            designationComboBox.SelectedIndex = -1;
        }

        private void SelectDesignation(int designationId)
        {
            for (int i = 0; i < designationComboBox.Items.Count; i++)
            {
                var item = designationComboBox.Items[i] as Lookup;
                if (item != null && item.Id == designationId)
                {
                    designationComboBox.SelectedIndex = i;
                    return;
                }
            }
            designationComboBox.SelectedIndex = -1;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            designationComboBox.SelectedIndex = -1;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            salaryTextBox.Text = string.Empty;
            contactTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            dateTimePicker1.Checked = false;
            genderComboBox.SelectedIndex = -1;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SaveAdvisor(currentMode == FormMode.Update);
        }

        private Advisor BuildAdvisorFromForm()
        {
            decimal parsedSalary;
            int parsedDesignation;
            var designationText = textBox2.Text.Trim();

            if (!int.TryParse(designationText, out parsedDesignation))
            {
                var match = designationLookups.FirstOrDefault(d => d.Value.Equals(designationText, StringComparison.OrdinalIgnoreCase));
                parsedDesignation = match != null ? match.Id : -1;
            }

            return new Advisor
            {
                Id = editingAdvisorId,
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Contact = contactTextBox.Text,
                Email = emailTextBox.Text,
                DateOfBirth = dateTimePicker1.Checked ? (DateTime?)dateTimePicker1.Value.Date : null,
                Gender = genderComboBox.SelectedIndex,
                Designation = selectedDesignation != null ? selectedDesignation.Id : -1,
                DesignationLabel = selectedDesignation != null ? selectedDesignation.Value : string.Empty,
                Salary = decimal.TryParse(textBox1.Text.Trim(), out parsedSalary) ? (decimal?)parsedSalary : null
            };
        }

        private void SaveAdvisor(bool isUpdate)
        {
            ApplicationStatusService.PublishInfo(isUpdate ? "Updating advisor record..." : "Adding advisor record...");
            var advisor = BuildAdvisorFromForm();

            string errorMessage;
            bool success = AdvisorBL.SaveAdvisor(advisor, isUpdate, out errorMessage);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show($"Error: {errorMessage}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!success)
            {
                MessageBox.Show("Unable to save advisor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApplicationStatusService.PublishSuccess(isUpdate ? "Advisor updated successfully." : "Advisor added successfully.");
            advisorAdded?.Invoke(this, EventArgs.Empty);
            MessageBox.Show(isUpdate ? "Advisor updated successfully." : "Advisor added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private string ResolveDesignationText(int designationId)
        {
            var match = designationLookups.FirstOrDefault(d => d.Id == designationId);
            return match != null ? match.Value : designationId.ToString();
        }
    }
}
