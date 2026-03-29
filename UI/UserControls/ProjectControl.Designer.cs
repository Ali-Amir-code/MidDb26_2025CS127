namespace MidDb26_2025CS127.UI.UserControls
{
    partial class ProjectControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.breadcrumbLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.accentBar = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gridContainer = new System.Windows.Forms.TableLayoutPanel();
            this.gridHeader = new System.Windows.Forms.Panel();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.sortByLabel = new System.Windows.Forms.Label();
            this.gridHeaderLabel = new System.Windows.Forms.Label();
            this.projectListGrid = new System.Windows.Forms.DataGridView();
            this.titleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.exportProjectBtn = new System.Windows.Forms.Button();
            this.importProjectBtn = new System.Windows.Forms.Button();
            this.deleteProjectsBtn = new System.Windows.Forms.Button();
            this.addProjectBtn = new System.Windows.Forms.Button();
            this.formPanel = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.regNoTextBox = new System.Windows.Forms.TextBox();
            this.projectTitleLabel = new System.Windows.Forms.Label();
            this.saperator = new System.Windows.Forms.Panel();
            this.formLabel = new System.Windows.Forms.Label();
            this.industryAdvisorComboBox = new System.Windows.Forms.ComboBox();
            this.coAdvisorComboBox = new System.Windows.Forms.ComboBox();
            this.mainAdvisorComboBox = new System.Windows.Forms.ComboBox();
            this.mainAdvisorLabel = new System.Windows.Forms.Label();
            this.coAdvisorLabel = new System.Windows.Forms.Label();
            this.industyAdvisorLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.gridContainer.SuspendLayout();
            this.gridHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectListGrid)).BeginInit();
            this.actionPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
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
            this.headerPanel.Size = new System.Drawing.Size(855, 95);
            this.headerPanel.TabIndex = 2;
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.subtitleLabel.Location = new System.Drawing.Point(22, 70);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(247, 20);
            this.subtitleLabel.TabIndex = 3;
            this.subtitleLabel.Text = "Add, view, edit and remove projects";
            // 
            // breadcrumbLabel
            // 
            this.breadcrumbLabel.AutoSize = true;
            this.breadcrumbLabel.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breadcrumbLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.breadcrumbLabel.Location = new System.Drawing.Point(25, 8);
            this.breadcrumbLabel.Name = "breadcrumbLabel";
            this.breadcrumbLabel.Size = new System.Drawing.Size(98, 15);
            this.breadcrumbLabel.TabIndex = 2;
            this.breadcrumbLabel.Text = "Home  ›  Projects";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.titleLabel.Location = new System.Drawing.Point(17, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(360, 45);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Projects Management";
            // 
            // accentBar
            // 
            this.accentBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.accentBar.Location = new System.Drawing.Point(0, 8);
            this.accentBar.Name = "accentBar";
            this.accentBar.Size = new System.Drawing.Size(4, 75);
            this.accentBar.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.mainPanel.Controls.Add(this.gridContainer, 0, 0);
            this.mainPanel.Controls.Add(this.formPanel, 1, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 95);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 1;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Size = new System.Drawing.Size(855, 428);
            this.mainPanel.TabIndex = 3;
            // 
            // gridContainer
            // 
            this.gridContainer.ColumnCount = 1;
            this.gridContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gridContainer.Controls.Add(this.gridHeader, 0, 0);
            this.gridContainer.Controls.Add(this.projectListGrid, 0, 1);
            this.gridContainer.Controls.Add(this.actionPanel, 0, 2);
            this.gridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContainer.Location = new System.Drawing.Point(3, 3);
            this.gridContainer.Name = "gridContainer";
            this.gridContainer.RowCount = 3;
            this.gridContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.gridContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gridContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.gridContainer.Size = new System.Drawing.Size(598, 422);
            this.gridContainer.TabIndex = 0;
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
            this.gridHeader.Size = new System.Drawing.Size(592, 39);
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
            "Title"});
            this.sortComboBox.Location = new System.Drawing.Point(415, 4);
            this.sortComboBox.MaxDropDownItems = 12;
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(160, 24);
            this.sortComboBox.TabIndex = 3;
            // 
            // sortByLabel
            // 
            this.sortByLabel.AutoSize = true;
            this.sortByLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByLabel.Location = new System.Drawing.Point(345, 6);
            this.sortByLabel.Name = "sortByLabel";
            this.sortByLabel.Size = new System.Drawing.Size(62, 20);
            this.sortByLabel.TabIndex = 2;
            this.sortByLabel.Text = "Sort By:";
            // 
            // gridHeaderLabel
            // 
            this.gridHeaderLabel.AutoSize = true;
            this.gridHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridHeaderLabel.Location = new System.Drawing.Point(3, 6);
            this.gridHeaderLabel.Name = "gridHeaderLabel";
            this.gridHeaderLabel.Size = new System.Drawing.Size(73, 23);
            this.gridHeaderLabel.TabIndex = 1;
            this.gridHeaderLabel.Text = "Projects";
            // 
            // projectListGrid
            // 
            this.projectListGrid.AllowUserToAddRows = false;
            this.projectListGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.projectListGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.projectListGrid.BackgroundColor = System.Drawing.Color.White;
            this.projectListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectListGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.projectListGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.projectListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleColumn,
            this.groupColumn,
            this.descriptionColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.projectListGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.projectListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectListGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.projectListGrid.Location = new System.Drawing.Point(3, 48);
            this.projectListGrid.Name = "projectListGrid";
            this.projectListGrid.ReadOnly = true;
            this.projectListGrid.RowHeadersVisible = false;
            this.projectListGrid.RowHeadersWidth = 51;
            this.projectListGrid.RowTemplate.Height = 24;
            this.projectListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.projectListGrid.Size = new System.Drawing.Size(592, 317);
            this.projectListGrid.TabIndex = 0;
            // 
            // titleColumn
            // 
            this.titleColumn.HeaderText = "Title";
            this.titleColumn.MinimumWidth = 6;
            this.titleColumn.Name = "titleColumn";
            this.titleColumn.ReadOnly = true;
            this.titleColumn.Width = 125;
            // 
            // groupColumn
            // 
            this.groupColumn.HeaderText = "Group";
            this.groupColumn.MinimumWidth = 6;
            this.groupColumn.Name = "groupColumn";
            this.groupColumn.ReadOnly = true;
            this.groupColumn.Width = 125;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.HeaderText = "Description";
            this.descriptionColumn.MinimumWidth = 6;
            this.descriptionColumn.Name = "descriptionColumn";
            this.descriptionColumn.ReadOnly = true;
            this.descriptionColumn.Width = 125;
            // 
            // actionPanel
            // 
            this.actionPanel.BackColor = System.Drawing.Color.Transparent;
            this.actionPanel.Controls.Add(this.exportProjectBtn);
            this.actionPanel.Controls.Add(this.importProjectBtn);
            this.actionPanel.Controls.Add(this.deleteProjectsBtn);
            this.actionPanel.Controls.Add(this.addProjectBtn);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionPanel.Location = new System.Drawing.Point(3, 371);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(592, 48);
            this.actionPanel.TabIndex = 1;
            // 
            // exportProjectBtn
            // 
            this.exportProjectBtn.BackColor = System.Drawing.Color.White;
            this.exportProjectBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportProjectBtn.ForeColor = System.Drawing.Color.Black;
            this.exportProjectBtn.Location = new System.Drawing.Point(448, 9);
            this.exportProjectBtn.Name = "exportProjectBtn";
            this.exportProjectBtn.Size = new System.Drawing.Size(136, 30);
            this.exportProjectBtn.TabIndex = 3;
            this.exportProjectBtn.Text = "Export Selected";
            this.exportProjectBtn.UseVisualStyleBackColor = false;
            // 
            // importProjectBtn
            // 
            this.importProjectBtn.BackColor = System.Drawing.Color.White;
            this.importProjectBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importProjectBtn.ForeColor = System.Drawing.Color.Black;
            this.importProjectBtn.Location = new System.Drawing.Point(371, 9);
            this.importProjectBtn.Name = "importProjectBtn";
            this.importProjectBtn.Size = new System.Drawing.Size(72, 30);
            this.importProjectBtn.TabIndex = 2;
            this.importProjectBtn.Text = "Import";
            this.importProjectBtn.UseVisualStyleBackColor = false;
            // 
            // deleteProjectsBtn
            // 
            this.deleteProjectsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.deleteProjectsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProjectsBtn.ForeColor = System.Drawing.Color.White;
            this.deleteProjectsBtn.Location = new System.Drawing.Point(181, 9);
            this.deleteProjectsBtn.Name = "deleteProjectsBtn";
            this.deleteProjectsBtn.Size = new System.Drawing.Size(155, 30);
            this.deleteProjectsBtn.TabIndex = 1;
            this.deleteProjectsBtn.Text = "Delete Selected";
            this.deleteProjectsBtn.UseVisualStyleBackColor = false;
            // 
            // addProjectBtn
            // 
            this.addProjectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.addProjectBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProjectBtn.ForeColor = System.Drawing.Color.White;
            this.addProjectBtn.Location = new System.Drawing.Point(11, 10);
            this.addProjectBtn.Name = "addProjectBtn";
            this.addProjectBtn.Size = new System.Drawing.Size(155, 30);
            this.addProjectBtn.TabIndex = 0;
            this.addProjectBtn.Text = "Add Projects";
            this.addProjectBtn.UseVisualStyleBackColor = false;
            this.addProjectBtn.Click += new System.EventHandler(this.addProjectBtn_Click);
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.Transparent;
            this.formPanel.Controls.Add(this.industyAdvisorLabel);
            this.formPanel.Controls.Add(this.coAdvisorLabel);
            this.formPanel.Controls.Add(this.mainAdvisorLabel);
            this.formPanel.Controls.Add(this.industryAdvisorComboBox);
            this.formPanel.Controls.Add(this.coAdvisorComboBox);
            this.formPanel.Controls.Add(this.mainAdvisorComboBox);
            this.formPanel.Controls.Add(this.clearBtn);
            this.formPanel.Controls.Add(this.selectBtn);
            this.formPanel.Controls.Add(this.firstNameTextBox);
            this.formPanel.Controls.Add(this.descriptionLabel);
            this.formPanel.Controls.Add(this.regNoTextBox);
            this.formPanel.Controls.Add(this.projectTitleLabel);
            this.formPanel.Controls.Add(this.saperator);
            this.formPanel.Controls.Add(this.formLabel);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(607, 3);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(245, 422);
            this.formPanel.TabIndex = 1;
            this.formPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.formPanel_Paint);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.White;
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.Location = new System.Drawing.Point(122, 314);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(72, 30);
            this.clearBtn.TabIndex = 17;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            // 
            // selectBtn
            // 
            this.selectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.selectBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBtn.ForeColor = System.Drawing.Color.White;
            this.selectBtn.Location = new System.Drawing.Point(11, 314);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(105, 30);
            this.selectBtn.TabIndex = 16;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = false;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(11, 105);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(225, 22);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.descriptionLabel.Location = new System.Drawing.Point(8, 85);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(96, 17);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "DESCRIPTION:";
            this.descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Location = new System.Drawing.Point(11, 60);
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.Size = new System.Drawing.Size(225, 22);
            this.regNoTextBox.TabIndex = 3;
            // 
            // projectTitleLabel
            // 
            this.projectTitleLabel.AutoSize = true;
            this.projectTitleLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectTitleLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.projectTitleLabel.Location = new System.Drawing.Point(8, 39);
            this.projectTitleLabel.Name = "projectTitleLabel";
            this.projectTitleLabel.Size = new System.Drawing.Size(46, 17);
            this.projectTitleLabel.TabIndex = 2;
            this.projectTitleLabel.Text = "TITLE:";
            // 
            // saperator
            // 
            this.saperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saperator.Location = new System.Drawing.Point(3, 29);
            this.saperator.Name = "saperator";
            this.saperator.Size = new System.Drawing.Size(233, 3);
            this.saperator.TabIndex = 1;
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLabel.Location = new System.Drawing.Point(4, 4);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(119, 23);
            this.formLabel.TabIndex = 0;
            this.formLabel.Text = "Select Project";
            // 
            // industryAdvisorComboBox
            // 
            this.industryAdvisorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.industryAdvisorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.industryAdvisorComboBox.FormattingEnabled = true;
            this.industryAdvisorComboBox.Location = new System.Drawing.Point(11, 260);
            this.industryAdvisorComboBox.MaxDropDownItems = 12;
            this.industryAdvisorComboBox.Name = "industryAdvisorComboBox";
            this.industryAdvisorComboBox.Size = new System.Drawing.Size(225, 24);
            this.industryAdvisorComboBox.TabIndex = 67;
            // 
            // coAdvisorComboBox
            // 
            this.coAdvisorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coAdvisorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.coAdvisorComboBox.FormattingEnabled = true;
            this.coAdvisorComboBox.Location = new System.Drawing.Point(11, 213);
            this.coAdvisorComboBox.MaxDropDownItems = 12;
            this.coAdvisorComboBox.Name = "coAdvisorComboBox";
            this.coAdvisorComboBox.Size = new System.Drawing.Size(225, 24);
            this.coAdvisorComboBox.TabIndex = 65;
            this.coAdvisorComboBox.SelectedIndexChanged += new System.EventHandler(this.coAdvisorComboBox_SelectedIndexChanged);
            // 
            // mainAdvisorComboBox
            // 
            this.mainAdvisorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainAdvisorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainAdvisorComboBox.FormattingEnabled = true;
            this.mainAdvisorComboBox.Location = new System.Drawing.Point(11, 160);
            this.mainAdvisorComboBox.MaxDropDownItems = 12;
            this.mainAdvisorComboBox.Name = "mainAdvisorComboBox";
            this.mainAdvisorComboBox.Size = new System.Drawing.Size(225, 24);
            this.mainAdvisorComboBox.TabIndex = 63;
            this.mainAdvisorComboBox.SelectedIndexChanged += new System.EventHandler(this.mainAdvisorComboBox_SelectedIndexChanged);
            // 
            // mainAdvisorLabel
            // 
            this.mainAdvisorLabel.AutoSize = true;
            this.mainAdvisorLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainAdvisorLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainAdvisorLabel.Location = new System.Drawing.Point(8, 130);
            this.mainAdvisorLabel.Name = "mainAdvisorLabel";
            this.mainAdvisorLabel.Size = new System.Drawing.Size(108, 17);
            this.mainAdvisorLabel.TabIndex = 68;
            this.mainAdvisorLabel.Text = "MAIN ADVISOR:";
            // 
            // coAdvisorLabel
            // 
            this.coAdvisorLabel.AutoSize = true;
            this.coAdvisorLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coAdvisorLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.coAdvisorLabel.Location = new System.Drawing.Point(8, 188);
            this.coAdvisorLabel.Name = "coAdvisorLabel";
            this.coAdvisorLabel.Size = new System.Drawing.Size(92, 17);
            this.coAdvisorLabel.TabIndex = 69;
            this.coAdvisorLabel.Text = "CO-ADVISOR:";
            // 
            // industyAdvisorLabel
            // 
            this.industyAdvisorLabel.AutoSize = true;
            this.industyAdvisorLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.industyAdvisorLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.industyAdvisorLabel.Location = new System.Drawing.Point(8, 240);
            this.industyAdvisorLabel.Name = "industyAdvisorLabel";
            this.industyAdvisorLabel.Size = new System.Drawing.Size(137, 17);
            this.industyAdvisorLabel.TabIndex = 70;
            this.industyAdvisorLabel.Text = "INDUSTRY ADVISOR:";
            // 
            // ProjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "ProjectControl";
            this.Size = new System.Drawing.Size(855, 523);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.gridContainer.ResumeLayout(false);
            this.gridHeader.ResumeLayout(false);
            this.gridHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectListGrid)).EndInit();
            this.actionPanel.ResumeLayout(false);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
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
        private System.Windows.Forms.DataGridView projectListGrid;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button exportProjectBtn;
        private System.Windows.Forms.Button importProjectBtn;
        private System.Windows.Forms.Button deleteProjectsBtn;
        private System.Windows.Forms.Button addProjectBtn;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox regNoTextBox;
        private System.Windows.Forms.Label projectTitleLabel;
        private System.Windows.Forms.Panel saperator;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn;
        private System.Windows.Forms.Panel gridHeader;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.Label sortByLabel;
        private System.Windows.Forms.Label gridHeaderLabel;
        private System.Windows.Forms.ComboBox industryAdvisorComboBox;
        private System.Windows.Forms.ComboBox coAdvisorComboBox;
        private System.Windows.Forms.ComboBox mainAdvisorComboBox;
        private System.Windows.Forms.Label mainAdvisorLabel;
        private System.Windows.Forms.Label industyAdvisorLabel;
        private System.Windows.Forms.Label coAdvisorLabel;
    }
}
