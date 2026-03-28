namespace MidDb26_2025CS127.UI.UserControls
{
    partial class GroupControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.breadcrumbLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.accentBar = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gridContainer = new System.Windows.Forms.TableLayoutPanel();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.deleteGroupBtn = new System.Windows.Forms.Button();
            this.addGroupBtn = new System.Windows.Forms.Button();
            this.groupPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gridHeader = new System.Windows.Forms.Panel();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.sortByLabel = new System.Windows.Forms.Label();
            this.gridHeaderLabel = new System.Windows.Forms.Label();
            this.groupGrid = new System.Windows.Forms.DataGridView();
            this.groupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDetailPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupDetailLabel = new System.Windows.Forms.Label();
            this.groupDetailBodyPanel = new System.Windows.Forms.Panel();
            this.underlinePanel = new System.Windows.Forms.Panel();
            this.editGroupBtn = new System.Windows.Forms.Button();
            this.membersLabel = new System.Windows.Forms.Label();
            this.studentListPanel = new System.Windows.Forms.Panel();
            this.studentList = new System.Windows.Forms.ListBox();
            this.projectNameValueLabel = new System.Windows.Forms.Label();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.groupNameValueLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.gridContainer.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.groupPanel.SuspendLayout();
            this.gridHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupGrid)).BeginInit();
            this.groupDetailPanel.SuspendLayout();
            this.groupDetailBodyPanel.SuspendLayout();
            this.studentListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Transparent;
            this.headerPanel.Controls.Add(this.subtitleLabel);
            this.headerPanel.Controls.Add(this.breadcrumbLabel);
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Controls.Add(this.accentBar);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.headerPanel.Size = new System.Drawing.Size(876, 95);
            this.headerPanel.TabIndex = 2;
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.subtitleLabel.Location = new System.Drawing.Point(22, 70);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(243, 20);
            this.subtitleLabel.TabIndex = 3;
            this.subtitleLabel.Text = "Add, view, edit and remove groups.";
            // 
            // breadcrumbLabel
            // 
            this.breadcrumbLabel.AutoSize = true;
            this.breadcrumbLabel.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breadcrumbLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.breadcrumbLabel.Location = new System.Drawing.Point(25, 8);
            this.breadcrumbLabel.Name = "breadcrumbLabel";
            this.breadcrumbLabel.Size = new System.Drawing.Size(94, 15);
            this.breadcrumbLabel.TabIndex = 2;
            this.breadcrumbLabel.Text = "Home  ›  Groups";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.titleLabel.Location = new System.Drawing.Point(17, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(332, 45);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Group Management";
            // 
            // accentBar
            // 
            this.accentBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.accentBar.Location = new System.Drawing.Point(0, 8);
            this.accentBar.Name = "accentBar";
            this.accentBar.Size = new System.Drawing.Size(4, 75);
            this.accentBar.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.gridContainer, 0, 0);
            this.mainPanel.Controls.Add(this.groupDetailPanel, 1, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 95);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 1;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Size = new System.Drawing.Size(876, 438);
            this.mainPanel.TabIndex = 3;
            // 
            // gridContainer
            // 
            this.gridContainer.ColumnCount = 1;
            this.gridContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gridContainer.Controls.Add(this.actionPanel, 0, 1);
            this.gridContainer.Controls.Add(this.groupPanel, 0, 0);
            this.gridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContainer.Location = new System.Drawing.Point(3, 3);
            this.gridContainer.Name = "gridContainer";
            this.gridContainer.RowCount = 2;
            this.gridContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gridContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.gridContainer.Size = new System.Drawing.Size(394, 432);
            this.gridContainer.TabIndex = 0;
            // 
            // actionPanel
            // 
            this.actionPanel.BackColor = System.Drawing.Color.Transparent;
            this.actionPanel.Controls.Add(this.deleteGroupBtn);
            this.actionPanel.Controls.Add(this.addGroupBtn);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionPanel.Location = new System.Drawing.Point(3, 381);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(388, 48);
            this.actionPanel.TabIndex = 1;
            // 
            // deleteGroupBtn
            // 
            this.deleteGroupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.deleteGroupBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteGroupBtn.ForeColor = System.Drawing.Color.White;
            this.deleteGroupBtn.Location = new System.Drawing.Point(172, 9);
            this.deleteGroupBtn.Name = "deleteGroupBtn";
            this.deleteGroupBtn.Size = new System.Drawing.Size(155, 30);
            this.deleteGroupBtn.TabIndex = 1;
            this.deleteGroupBtn.Text = "Delete Selected";
            this.deleteGroupBtn.UseVisualStyleBackColor = false;
            // 
            // addGroupBtn
            // 
            this.addGroupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.addGroupBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupBtn.ForeColor = System.Drawing.Color.White;
            this.addGroupBtn.Location = new System.Drawing.Point(8, 10);
            this.addGroupBtn.Name = "addGroupBtn";
            this.addGroupBtn.Size = new System.Drawing.Size(155, 30);
            this.addGroupBtn.TabIndex = 0;
            this.addGroupBtn.Text = "Add Group";
            this.addGroupBtn.UseVisualStyleBackColor = false;
            this.addGroupBtn.Click += new System.EventHandler(this.addGroupBtn_Click);
            // 
            // groupPanel
            // 
            this.groupPanel.ColumnCount = 1;
            this.groupPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.groupPanel.Controls.Add(this.gridHeader, 0, 0);
            this.groupPanel.Controls.Add(this.groupGrid, 2, 1);
            this.groupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel.Location = new System.Drawing.Point(3, 3);
            this.groupPanel.Name = "groupPanel";
            this.groupPanel.RowCount = 2;
            this.groupPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.groupPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.groupPanel.Size = new System.Drawing.Size(388, 372);
            this.groupPanel.TabIndex = 2;
            // 
            // gridHeader
            // 
            this.gridHeader.BackColor = System.Drawing.Color.White;
            this.gridHeader.Controls.Add(this.sortComboBox);
            this.gridHeader.Controls.Add(this.sortByLabel);
            this.gridHeader.Controls.Add(this.gridHeaderLabel);
            this.gridHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHeader.Location = new System.Drawing.Point(3, 3);
            this.gridHeader.Name = "gridHeader";
            this.gridHeader.Size = new System.Drawing.Size(382, 31);
            this.gridHeader.TabIndex = 9;
            // 
            // sortComboBox
            // 
            this.sortComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.sortComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sortComboBox.BackColor = System.Drawing.Color.White;
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Group Name",
            "Date"});
            this.sortComboBox.Location = new System.Drawing.Point(198, 3);
            this.sortComboBox.MaxDropDownItems = 12;
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(160, 24);
            this.sortComboBox.TabIndex = 3;
            // 
            // sortByLabel
            // 
            this.sortByLabel.AutoSize = true;
            this.sortByLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByLabel.Location = new System.Drawing.Point(134, 5);
            this.sortByLabel.Name = "sortByLabel";
            this.sortByLabel.Size = new System.Drawing.Size(62, 20);
            this.sortByLabel.TabIndex = 2;
            this.sortByLabel.Text = "Sort By:";
            // 
            // gridHeaderLabel
            // 
            this.gridHeaderLabel.AutoSize = true;
            this.gridHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridHeaderLabel.Location = new System.Drawing.Point(3, 4);
            this.gridHeaderLabel.Name = "gridHeaderLabel";
            this.gridHeaderLabel.Size = new System.Drawing.Size(67, 23);
            this.gridHeaderLabel.TabIndex = 1;
            this.gridHeaderLabel.Text = "Groups";
            // 
            // groupGrid
            // 
            this.groupGrid.BackgroundColor = System.Drawing.Color.White;
            this.groupGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.groupGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groupGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.groupGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupName,
            this.groupDate});
            this.groupGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupGrid.GridColor = System.Drawing.Color.White;
            this.groupGrid.Location = new System.Drawing.Point(3, 40);
            this.groupGrid.MultiSelect = false;
            this.groupGrid.Name = "groupGrid";
            this.groupGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.groupGrid.RowHeadersVisible = false;
            this.groupGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.groupGrid.RowTemplate.Height = 24;
            this.groupGrid.Size = new System.Drawing.Size(382, 329);
            this.groupGrid.TabIndex = 1;
            this.groupGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupGrid_CellContentClick);
            // 
            // groupName
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.groupName.DefaultCellStyle = dataGridViewCellStyle2;
            this.groupName.HeaderText = "Group Name";
            this.groupName.MinimumWidth = 6;
            this.groupName.Name = "groupName";
            this.groupName.ReadOnly = true;
            this.groupName.Width = 200;
            // 
            // groupDate
            // 
            this.groupDate.HeaderText = "Created At";
            this.groupDate.MinimumWidth = 6;
            this.groupDate.Name = "groupDate";
            this.groupDate.Width = 125;
            // 
            // groupDetailPanel
            // 
            this.groupDetailPanel.BackColor = System.Drawing.Color.Transparent;
            this.groupDetailPanel.ColumnCount = 1;
            this.groupDetailPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.groupDetailPanel.Controls.Add(this.groupDetailLabel, 0, 0);
            this.groupDetailPanel.Controls.Add(this.groupDetailBodyPanel, 0, 1);
            this.groupDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDetailPanel.Location = new System.Drawing.Point(403, 3);
            this.groupDetailPanel.Name = "groupDetailPanel";
            this.groupDetailPanel.RowCount = 2;
            this.groupDetailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.953704F));
            this.groupDetailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0463F));
            this.groupDetailPanel.Size = new System.Drawing.Size(470, 432);
            this.groupDetailPanel.TabIndex = 1;
            // 
            // groupDetailLabel
            // 
            this.groupDetailLabel.AutoSize = true;
            this.groupDetailLabel.BackColor = System.Drawing.Color.Transparent;
            this.groupDetailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDetailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDetailLabel.Location = new System.Drawing.Point(3, 0);
            this.groupDetailLabel.Name = "groupDetailLabel";
            this.groupDetailLabel.Size = new System.Drawing.Size(464, 42);
            this.groupDetailLabel.TabIndex = 1;
            this.groupDetailLabel.Text = "Group Details";
            this.groupDetailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupDetailBodyPanel
            // 
            this.groupDetailBodyPanel.BackColor = System.Drawing.Color.Transparent;
            this.groupDetailBodyPanel.Controls.Add(this.underlinePanel);
            this.groupDetailBodyPanel.Controls.Add(this.editGroupBtn);
            this.groupDetailBodyPanel.Controls.Add(this.membersLabel);
            this.groupDetailBodyPanel.Controls.Add(this.studentListPanel);
            this.groupDetailBodyPanel.Controls.Add(this.projectNameValueLabel);
            this.groupDetailBodyPanel.Controls.Add(this.projectNameLabel);
            this.groupDetailBodyPanel.Controls.Add(this.groupNameValueLabel);
            this.groupDetailBodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDetailBodyPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupDetailBodyPanel.Location = new System.Drawing.Point(3, 45);
            this.groupDetailBodyPanel.Name = "groupDetailBodyPanel";
            this.groupDetailBodyPanel.Size = new System.Drawing.Size(464, 384);
            this.groupDetailBodyPanel.TabIndex = 0;
            // 
            // underlinePanel
            // 
            this.underlinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.underlinePanel.Location = new System.Drawing.Point(41, 38);
            this.underlinePanel.Name = "underlinePanel";
            this.underlinePanel.Size = new System.Drawing.Size(150, 3);
            this.underlinePanel.TabIndex = 15;
            // 
            // editGroupBtn
            // 
            this.editGroupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.editGroupBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editGroupBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editGroupBtn.ForeColor = System.Drawing.Color.White;
            this.editGroupBtn.Location = new System.Drawing.Point(0, 354);
            this.editGroupBtn.Name = "editGroupBtn";
            this.editGroupBtn.Size = new System.Drawing.Size(464, 30);
            this.editGroupBtn.TabIndex = 14;
            this.editGroupBtn.Text = "Edit Group";
            this.editGroupBtn.UseVisualStyleBackColor = false;
            // 
            // membersLabel
            // 
            this.membersLabel.AutoSize = true;
            this.membersLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.membersLabel.Location = new System.Drawing.Point(40, 63);
            this.membersLabel.Name = "membersLabel";
            this.membersLabel.Size = new System.Drawing.Size(97, 23);
            this.membersLabel.TabIndex = 13;
            this.membersLabel.Text = "MEMBERS:";
            // 
            // studentListPanel
            // 
            this.studentListPanel.Controls.Add(this.studentList);
            this.studentListPanel.Location = new System.Drawing.Point(93, 89);
            this.studentListPanel.Name = "studentListPanel";
            this.studentListPanel.Size = new System.Drawing.Size(202, 141);
            this.studentListPanel.TabIndex = 12;
            // 
            // studentList
            // 
            this.studentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentList.FormattingEnabled = true;
            this.studentList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.studentList.ItemHeight = 23;
            this.studentList.Items.AddRange(new object[] {
            "◈ Student1",
            "◈ Student2",
            "◈ Student3",
            "◈ Student4",
            "◈ Student5",
            "◈ Student6"});
            this.studentList.Location = new System.Drawing.Point(0, 0);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(202, 141);
            this.studentList.TabIndex = 0;
            // 
            // projectNameValueLabel
            // 
            this.projectNameValueLabel.AutoSize = true;
            this.projectNameValueLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameValueLabel.Location = new System.Drawing.Point(145, 242);
            this.projectNameValueLabel.Name = "projectNameValueLabel";
            this.projectNameValueLabel.Size = new System.Drawing.Size(150, 23);
            this.projectNameValueLabel.TabIndex = 11;
            this.projectNameValueLabel.Text = "project name here";
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.projectNameLabel.Location = new System.Drawing.Point(40, 242);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(87, 23);
            this.projectNameLabel.TabIndex = 10;
            this.projectNameLabel.Text = "PROJECT:";
            // 
            // groupNameValueLabel
            // 
            this.groupNameValueLabel.AutoSize = true;
            this.groupNameValueLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNameValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.groupNameValueLabel.Location = new System.Drawing.Point(34, 0);
            this.groupNameValueLabel.Name = "groupNameValueLabel";
            this.groupNameValueLabel.Size = new System.Drawing.Size(126, 41);
            this.groupNameValueLabel.TabIndex = 9;
            this.groupNameValueLabel.Text = "GroupX";
            // 
            // GroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "GroupControl";
            this.Size = new System.Drawing.Size(876, 533);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.gridContainer.ResumeLayout(false);
            this.actionPanel.ResumeLayout(false);
            this.groupPanel.ResumeLayout(false);
            this.gridHeader.ResumeLayout(false);
            this.gridHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupGrid)).EndInit();
            this.groupDetailPanel.ResumeLayout(false);
            this.groupDetailPanel.PerformLayout();
            this.groupDetailBodyPanel.ResumeLayout(false);
            this.groupDetailBodyPanel.PerformLayout();
            this.studentListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Label breadcrumbLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel accentBar;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.TableLayoutPanel gridContainer;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button deleteGroupBtn;
        private System.Windows.Forms.Button addGroupBtn;
        private System.Windows.Forms.TableLayoutPanel groupPanel;
        private System.Windows.Forms.TableLayoutPanel groupDetailPanel;
        private System.Windows.Forms.Label groupDetailLabel;
        private System.Windows.Forms.Panel groupDetailBodyPanel;
        private System.Windows.Forms.Label membersLabel;
        private System.Windows.Forms.Panel studentListPanel;
        private System.Windows.Forms.Label projectNameValueLabel;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Label groupNameValueLabel;
        private System.Windows.Forms.Button editGroupBtn;
        private System.Windows.Forms.ListBox studentList;
        private System.Windows.Forms.DataGridView groupGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDate;
        private System.Windows.Forms.Panel underlinePanel;
        private System.Windows.Forms.Panel gridHeader;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.Label sortByLabel;
        private System.Windows.Forms.Label gridHeaderLabel;
    }
}
