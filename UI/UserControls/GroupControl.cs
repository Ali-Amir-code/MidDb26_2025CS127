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
    public partial class GroupControl : UserControl
    {
        private const string HiddenIdColumnName = "groupIdHiddenColumn";

        private List<Group> groups = new List<Group>();

        public GroupControl()
        {
            InitializeComponent();
            EnsureHiddenIdColumn();
            groupGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            groupGrid.MultiSelect = true;

            deleteGroupBtn.Click += deleteGroupBtn_Click;
            groupGrid.SelectionChanged += groupGrid_SelectionChanged;
            sortComboBox.SelectedIndexChanged += sortComboBox_SelectedIndexChanged;

            RefreshData();
        }

        private void EnsureHiddenIdColumn()
        {
            if (groupGrid.Columns.Contains(HiddenIdColumnName))
            {
                return;
            }

            var hiddenColumn = new DataGridViewTextBoxColumn
            {
                Name = HiddenIdColumnName,
                Visible = false
            };
            groupGrid.Columns.Add(hiddenColumn);
        }

        private void RefreshData()
        {
            groups = GroupBL.GetAllGroups();
            LoadGroups(groups);
            LoadGroupDetail(null);
            ApplicationStatusService.PublishSuccess("Group records loaded.");
        }

        private void LoadGroups(List<Group> source)
        {
            groupGrid.Rows.Clear();
            foreach (var group in source)
            {
                var rowIndex = groupGrid.Rows.Add(group.DisplayName, group.Created_On.ToShortDateString());
                groupGrid.Rows[rowIndex].Cells[HiddenIdColumnName].Value = group.Id;
            }
        }

        private void LoadGroupDetail(Group group)
        {
            if (group == null)
            {
                groupNameValueLabel.Text = "Select a group";
                projectNameValueLabel.Text = "-";
                studentList.Items.Clear();
                return;
            }

            groupNameValueLabel.Text = group.DisplayName;
            projectNameValueLabel.Text = string.IsNullOrWhiteSpace(group.ProjectTitle) ? "Not assigned" : group.ProjectTitle;

            studentList.Items.Clear();
            foreach (var member in group.Members)
            {
                studentList.Items.Add($"◈ {member.RegistrationNo} - {member.FirstName} {member.LastName}".Trim());
            }

            if (studentList.Items.Count == 0)
            {
                studentList.Items.Add("No students assigned");
            }
        }

        private Group GetSelectedGroup()
        {
            if (groupGrid.CurrentRow == null || groupGrid.CurrentRow.Cells[HiddenIdColumnName].Value == null)
            {
                return null;
            }

            int groupId = Convert.ToInt32(groupGrid.CurrentRow.Cells[HiddenIdColumnName].Value);
            return groups.FirstOrDefault(g => g.Id == groupId);
        }

        private void addGroupBtn_Click(object sender, EventArgs e)
        {
            using (var form = new AddGroupForm())
            {
                form.groupSaved += Form_groupSaved;
                form.ShowDialog();
            }
        }

        private void Form_groupSaved(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void deleteGroupBtn_Click(object sender, EventArgs e)
        {
            var selectedRows = groupGrid.SelectedRows.Cast<DataGridViewRow>().ToList();
            if (!selectedRows.Any() && groupGrid.CurrentRow != null)
            {
                selectedRows.Add(groupGrid.CurrentRow);
            }

            if (!selectedRows.Any())
            {
                MessageBox.Show("Select a group to delete.", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Delete selected group(s)?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            var ids = selectedRows
                .Where(r => r.Cells[HiddenIdColumnName].Value != null)
                .Select(r => Convert.ToInt32(r.Cells[HiddenIdColumnName].Value))
                .Distinct()
                .ToList();

            GroupBL.DeleteGroups(ids);
            RefreshData();
        }

        private void groupGrid_SelectionChanged(object sender, EventArgs e)
        {
            LoadGroupDetail(GetSelectedGroup());
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortKey = sortComboBox.SelectedItem != null ? sortComboBox.SelectedItem.ToString() : string.Empty;
            LoadGroups(GroupBL.SortGroups(groups, sortKey));
        }

        private void regLabel_Click(object sender, EventArgs e) { }
        private void groupList_SelectedIndexChanged(object sender, EventArgs e) { }
        private void groupGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
