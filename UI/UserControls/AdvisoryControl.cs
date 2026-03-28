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
    public partial class AdvisoryControl : UserControl
    {
        private List<Advisor> advisors = new List<Advisor>();

        public AdvisoryControl(List<Advisor> advisors)
        {
            InitializeComponent();
            this.advisors = advisors ?? new List<Advisor>();
            LoadAdvisors(this.advisors);
            ApplicationStatusService.PublishSuccess("Advisor records loaded.");

            selectBtn.Click += selectBtn_Click;
            clearBtn.Click += clearBtn_Click;
            deleteAdvisorBtn.Click += deleteAdvisorBtn_Click;
            advisorListGrid.CellContentClick += advisorListGrid_CellContentClick;
        }

        private void LoadAdvisors(List<Advisor> advisorItems)
        {
            advisors = advisorItems ?? new List<Advisor>();
            advisorListGrid.Rows.Clear();

            foreach (var item in advisors)
            {
                advisorListGrid.Rows.Add(
                    item.Id,
                    item.FirstName,
                    item.LastName,
                    item.DesignationLabel,
                    item.Salary.HasValue ? item.Salary.Value.ToString("0.##") : string.Empty,
                    item.Contact,
                    item.Email,
                    item.DateOfBirth.HasValue ? item.DateOfBirth.Value.ToShortDateString() : string.Empty,
                    item.Gender.HasValue ? (item.Gender.Value == 1 ? "Male" : "Female") : string.Empty,
                    string.Empty,
                    "Delete",
                    "Edit");
            }
        }

        private void RefreshData()
        {
            ApplicationStatusService.PublishInfo("Refreshing advisor data...");
            LoadAdvisors(AdvisorBL.GetAllAdvisors());
        }

        private void addAdvisorBtn_Click(object sender, EventArgs e)
        {
            ApplicationStatusService.PublishInfo("Opening Add Advisor dialog...");
            using (var form = new AddAdvisorForm())
            {
                form.advisorAdded += Form_advisorAdded;
                form.ShowDialog();
            }
        }

        private void Form_advisorAdded(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text.Trim();
            string lastName = lastNameTextBox.Text.Trim();
            string designation = textBox2.Text.Trim();
            string salary = textBox1.Text.Trim();
            string contact = contactTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string genderText = genderComboBox.SelectedItem != null ? genderComboBox.SelectedItem.ToString() : string.Empty;
            bool dobChecked = dateTimePicker1 != null && dateTimePicker1.Checked;
            DateTime? dob = dobChecked ? (DateTime?)dateTimePicker1.Value.Date : null;

            bool hasAnyCriteria = !string.IsNullOrWhiteSpace(firstName)
                || !string.IsNullOrWhiteSpace(lastName)
                || !string.IsNullOrWhiteSpace(designation)
                || !string.IsNullOrWhiteSpace(salary)
                || !string.IsNullOrWhiteSpace(contact)
                || !string.IsNullOrWhiteSpace(email)
                || (!string.IsNullOrWhiteSpace(genderText) && !genderText.Equals("All", StringComparison.OrdinalIgnoreCase))
                || dobChecked;

            if (!hasAnyCriteria)
            {
                LoadAdvisors(advisors);
                if (dateTimePicker1 != null) dateTimePicker1.Checked = false;
                return;
            }

            int? genderVal = null;
            if (!string.IsNullOrWhiteSpace(genderText) && !genderText.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                if (genderText.Equals("Male", StringComparison.OrdinalIgnoreCase)) genderVal = 1;
                else if (genderText.Equals("Female", StringComparison.OrdinalIgnoreCase)) genderVal = 2;
            }

            var filtered = AdvisorBL.FilterAdvisors(advisors, firstName, lastName, designation, salary, contact, email, genderVal, dob);

            if (!filtered.Any())
            {
                MessageBox.Show("No advisor found matching provided criteria.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dateTimePicker1 != null) dateTimePicker1.Checked = false;
                return;
            }

            if (dateTimePicker1 != null) dateTimePicker1.Checked = false;
            LoadAdvisors(filtered);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
            contactTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            genderComboBox.SelectedIndex = -1;
            dateTimePicker1.Checked = false;
            LoadAdvisors(advisors);
        }

        private void deleteAdvisorBtn_Click(object sender, EventArgs e)
        {
            if (advisorListGrid.Rows.Count == 0)
            {
                MessageBox.Show("Select an advisor to delete.", "Delete Advisor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Delete all currently listed advisors?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            var ids = advisorListGrid.Rows
                .Cast<DataGridViewRow>()
                .Where(row => row.Cells["idColumn"].Value != null)
                .Select(row => Convert.ToInt32(row.Cells["idColumn"].Value))
                .Distinct()
                .ToList();

            AdvisorBL.DeleteAdvisors(ids);
            RefreshData();
        }

        private void advisorListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (advisorListGrid.Columns[e.ColumnIndex].Name == "deleteColumn")
            {
                int advisorId = Convert.ToInt32(advisorListGrid.Rows[e.RowIndex].Cells["idColumn"].Value);
                if (MessageBox.Show("Delete selected advisor?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    AdvisorBL.DeleteAdvisor(advisorId);
                    RefreshData();
                }
            }
            else if (advisorListGrid.Columns[e.ColumnIndex].Name == "editColumn")
            {
                int advisorId = Convert.ToInt32(advisorListGrid.Rows[e.RowIndex].Cells["idColumn"].Value);
                var advisor = advisors.FirstOrDefault(a => a.Id == advisorId);
                if (advisor == null)
                {
                    return;
                }

                using (var form = new AddAdvisorForm(advisor, "Edit Advisor", "Update"))
                {
                    form.advisorAdded += Form_advisorAdded;
                    form.ShowDialog();
                }
            }
        }
    }
}
