namespace MidDb26_2025CS127.UI.UserControls
{
    partial class AdvisoryControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.breadcrumbLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.accentBar = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gridContainer = new System.Windows.Forms.TableLayoutPanel();
            this.advisorListGrid = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.exportAdvisorBtn = new System.Windows.Forms.Button();
            this.importAdvisorBtn = new System.Windows.Forms.Button();
            this.deleteAdvisorBtn = new System.Windows.Forms.Button();
            this.addAdvisorBtn = new System.Windows.Forms.Button();
            this.formPanel = new System.Windows.Forms.Panel();
            this.designationComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.designationComboBox = new System.Windows.Forms.ComboBox();
            this.designationLabel = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.contactLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.saperator = new System.Windows.Forms.Panel();
            this.formLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.gridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advisorListGrid)).BeginInit();
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
            this.headerPanel.Size = new System.Drawing.Size(858, 95);
            this.headerPanel.TabIndex = 2;
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.subtitleLabel.Location = new System.Drawing.Point(22, 70);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(248, 20);
            this.subtitleLabel.TabIndex = 3;
            this.subtitleLabel.Text = "Add, view, edit and remove advisors";
            // 
            // breadcrumbLabel
            // 
            this.breadcrumbLabel.AutoSize = true;
            this.breadcrumbLabel.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breadcrumbLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.breadcrumbLabel.Location = new System.Drawing.Point(25, 8);
            this.breadcrumbLabel.Name = "breadcrumbLabel";
            this.breadcrumbLabel.Size = new System.Drawing.Size(101, 15);
            this.breadcrumbLabel.TabIndex = 2;
            this.breadcrumbLabel.Text = "Home  ›  Advisors";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.titleLabel.Location = new System.Drawing.Point(17, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(354, 45);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Advisor Management";
            // 
            // accentBar
            // 
            this.accentBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
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
            this.mainPanel.Size = new System.Drawing.Size(858, 485);
            this.mainPanel.TabIndex = 3;
            // 
            // gridContainer
            // 
            this.gridContainer.ColumnCount = 1;
            this.gridContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gridContainer.Controls.Add(this.advisorListGrid, 0, 0);
            this.gridContainer.Controls.Add(this.actionPanel, 0, 1);
            this.gridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContainer.Location = new System.Drawing.Point(3, 3);
            this.gridContainer.Name = "gridContainer";
            this.gridContainer.RowCount = 2;
            this.gridContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gridContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.gridContainer.Size = new System.Drawing.Size(601, 479);
            this.gridContainer.TabIndex = 0;
            // 
            // advisorListGrid
            // 
            this.advisorListGrid.AllowUserToAddRows = false;
            this.advisorListGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.advisorListGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.advisorListGrid.BackgroundColor = System.Drawing.Color.White;
            this.advisorListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.advisorListGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.advisorListGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advisorListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.advisorListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advisorListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.firstNameColumn,
            this.lastNameColumn,
            this.designationColumn,
            this.salaryColumn,
            this.contactColumn,
            this.emailColumn,
            this.dobColumn,
            this.genderColumn,
            this.groupColumn,
            this.deleteColumn,
            this.editColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.advisorListGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.advisorListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advisorListGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.advisorListGrid.Location = new System.Drawing.Point(3, 3);
            this.advisorListGrid.Name = "advisorListGrid";
            this.advisorListGrid.ReadOnly = true;
            this.advisorListGrid.RowHeadersVisible = false;
            this.advisorListGrid.RowHeadersWidth = 51;
            this.advisorListGrid.RowTemplate.Height = 24;
            this.advisorListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.advisorListGrid.Size = new System.Drawing.Size(595, 418);
            this.advisorListGrid.TabIndex = 2;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            this.idColumn.Width = 125;
            // 
            // firstNameColumn
            // 
            this.firstNameColumn.HeaderText = "First Name";
            this.firstNameColumn.MinimumWidth = 6;
            this.firstNameColumn.Name = "firstNameColumn";
            this.firstNameColumn.ReadOnly = true;
            this.firstNameColumn.Width = 68;
            // 
            // lastNameColumn
            // 
            this.lastNameColumn.HeaderText = "Last Name";
            this.lastNameColumn.MinimumWidth = 6;
            this.lastNameColumn.Name = "lastNameColumn";
            this.lastNameColumn.ReadOnly = true;
            this.lastNameColumn.Width = 68;
            // 
            // designationColumn
            // 
            this.designationColumn.HeaderText = "Desgination";
            this.designationColumn.MinimumWidth = 6;
            this.designationColumn.Name = "designationColumn";
            this.designationColumn.ReadOnly = true;
            this.designationColumn.Width = 125;
            // 
            // salaryColumn
            // 
            this.salaryColumn.HeaderText = "Salary";
            this.salaryColumn.MinimumWidth = 6;
            this.salaryColumn.Name = "salaryColumn";
            this.salaryColumn.ReadOnly = true;
            this.salaryColumn.Width = 125;
            // 
            // contactColumn
            // 
            this.contactColumn.HeaderText = "Contact";
            this.contactColumn.MinimumWidth = 6;
            this.contactColumn.Name = "contactColumn";
            this.contactColumn.ReadOnly = true;
            this.contactColumn.Width = 67;
            // 
            // emailColumn
            // 
            this.emailColumn.HeaderText = "Email";
            this.emailColumn.MinimumWidth = 6;
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.ReadOnly = true;
            this.emailColumn.Width = 68;
            // 
            // dobColumn
            // 
            this.dobColumn.HeaderText = "Date of Birth";
            this.dobColumn.MinimumWidth = 6;
            this.dobColumn.Name = "dobColumn";
            this.dobColumn.ReadOnly = true;
            this.dobColumn.Width = 68;
            // 
            // genderColumn
            // 
            this.genderColumn.HeaderText = "Gender";
            this.genderColumn.MinimumWidth = 6;
            this.genderColumn.Name = "genderColumn";
            this.genderColumn.ReadOnly = true;
            this.genderColumn.Width = 68;
            // 
            // groupColumn
            // 
            this.groupColumn.HeaderText = "Group";
            this.groupColumn.MinimumWidth = 6;
            this.groupColumn.Name = "groupColumn";
            this.groupColumn.ReadOnly = true;
            this.groupColumn.Width = 67;
            // 
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "Delete";
            this.deleteColumn.MinimumWidth = 6;
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            this.deleteColumn.Width = 68;
            // 
            // editColumn
            // 
            this.editColumn.HeaderText = "Edit";
            this.editColumn.MinimumWidth = 6;
            this.editColumn.Name = "editColumn";
            this.editColumn.ReadOnly = true;
            this.editColumn.Width = 125;
            // 
            // actionPanel
            // 
            this.actionPanel.BackColor = System.Drawing.Color.Transparent;
            this.actionPanel.Controls.Add(this.exportAdvisorBtn);
            this.actionPanel.Controls.Add(this.importAdvisorBtn);
            this.actionPanel.Controls.Add(this.deleteAdvisorBtn);
            this.actionPanel.Controls.Add(this.addAdvisorBtn);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionPanel.Location = new System.Drawing.Point(3, 427);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(595, 49);
            this.actionPanel.TabIndex = 1;
            // 
            // exportAdvisorBtn
            // 
            this.exportAdvisorBtn.BackColor = System.Drawing.Color.White;
            this.exportAdvisorBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportAdvisorBtn.ForeColor = System.Drawing.Color.Black;
            this.exportAdvisorBtn.Location = new System.Drawing.Point(448, 9);
            this.exportAdvisorBtn.Name = "exportAdvisorBtn";
            this.exportAdvisorBtn.Size = new System.Drawing.Size(136, 30);
            this.exportAdvisorBtn.TabIndex = 3;
            this.exportAdvisorBtn.Text = "Export Selected";
            this.exportAdvisorBtn.UseVisualStyleBackColor = false;
            // 
            // importAdvisorBtn
            // 
            this.importAdvisorBtn.BackColor = System.Drawing.Color.White;
            this.importAdvisorBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importAdvisorBtn.ForeColor = System.Drawing.Color.Black;
            this.importAdvisorBtn.Location = new System.Drawing.Point(371, 9);
            this.importAdvisorBtn.Name = "importAdvisorBtn";
            this.importAdvisorBtn.Size = new System.Drawing.Size(72, 30);
            this.importAdvisorBtn.TabIndex = 2;
            this.importAdvisorBtn.Text = "Import";
            this.importAdvisorBtn.UseVisualStyleBackColor = false;
            // 
            // deleteAdvisorBtn
            // 
            this.deleteAdvisorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.deleteAdvisorBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAdvisorBtn.ForeColor = System.Drawing.Color.White;
            this.deleteAdvisorBtn.Location = new System.Drawing.Point(181, 9);
            this.deleteAdvisorBtn.Name = "deleteAdvisorBtn";
            this.deleteAdvisorBtn.Size = new System.Drawing.Size(155, 30);
            this.deleteAdvisorBtn.TabIndex = 1;
            this.deleteAdvisorBtn.Text = "Delete Selected";
            this.deleteAdvisorBtn.UseVisualStyleBackColor = false;
            // 
            // addAdvisorBtn
            // 
            this.addAdvisorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.addAdvisorBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAdvisorBtn.ForeColor = System.Drawing.Color.White;
            this.addAdvisorBtn.Location = new System.Drawing.Point(11, 10);
            this.addAdvisorBtn.Name = "addAdvisorBtn";
            this.addAdvisorBtn.Size = new System.Drawing.Size(155, 30);
            this.addAdvisorBtn.TabIndex = 0;
            this.addAdvisorBtn.Text = "Add Advisor";
            this.addAdvisorBtn.UseVisualStyleBackColor = false;
            this.addAdvisorBtn.Click += new System.EventHandler(this.addAdvisorBtn_Click);
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.Transparent;
            this.formPanel.Controls.Add(this.dateTimePicker1);
            this.formPanel.Controls.Add(this.salaryTextBox);
            this.formPanel.Controls.Add(this.salaryLabel);
            this.formPanel.Controls.Add(this.designationComboBox);
            this.formPanel.Controls.Add(this.designationLabel);
            this.formPanel.Controls.Add(this.clearBtn);
            this.formPanel.Controls.Add(this.selectBtn);
            this.formPanel.Controls.Add(this.genderComboBox);
            this.formPanel.Controls.Add(this.genderLabel);
            this.formPanel.Controls.Add(this.dobLabel);
            this.formPanel.Controls.Add(this.emailTextBox);
            this.formPanel.Controls.Add(this.emailLabel);
            this.formPanel.Controls.Add(this.contactTextBox);
            this.formPanel.Controls.Add(this.contactLabel);
            this.formPanel.Controls.Add(this.lastNameTextBox);
            this.formPanel.Controls.Add(this.lastNameLabel);
            this.formPanel.Controls.Add(this.firstNameTextBox);
            this.formPanel.Controls.Add(this.firstNameLabel);
            this.formPanel.Controls.Add(this.saperator);
            this.formPanel.Controls.Add(this.formLabel);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(610, 3);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(245, 479);
            this.formPanel.TabIndex = 1;
            // 
            // designationComboBox
            // 
            this.designationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.designationComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.designationComboBox.FormattingEnabled = true;
            this.designationComboBox.Items.AddRange(new object[] {
            " All",
            "Professor",
            "Associate Professor",
            "Assistant Professor",
            "Lecturer",
            "Industry Professional"});
            this.designationComboBox.Location = new System.Drawing.Point(11, 150);
            this.designationComboBox.MaxDropDownItems = 12;
            this.designationComboBox.Name = "designationComboBox";
            this.designationComboBox.Size = new System.Drawing.Size(225, 24);
            this.designationComboBox.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 331);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 22);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(11, 195);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(225, 22);
            this.salaryTextBox.TabIndex = 21;
            this.salaryTextBox.Tag = "";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.salaryLabel.Location = new System.Drawing.Point(8, 175);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(56, 17);
            this.salaryLabel.TabIndex = 20;
            this.salaryLabel.Text = "SALARY";
            // 
            // designationComboBox
            // 
            this.designationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.designationComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.designationComboBox.FormattingEnabled = true;
            this.designationComboBox.Location = new System.Drawing.Point(11, 150);
            this.designationComboBox.MaxDropDownItems = 12;
            this.designationComboBox.Name = "designationComboBox";
            this.designationComboBox.Size = new System.Drawing.Size(225, 24);
            this.designationComboBox.TabIndex = 19;
            // 
            // designationLabel
            // 
            this.designationLabel.AutoSize = true;
            this.designationLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designationLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.designationLabel.Location = new System.Drawing.Point(11, 130);
            this.designationLabel.Name = "designationLabel";
            this.designationLabel.Size = new System.Drawing.Size(99, 17);
            this.designationLabel.TabIndex = 18;
            this.designationLabel.Text = "DESIGNATION:";
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.White;
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.Location = new System.Drawing.Point(121, 405);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(72, 30);
            this.clearBtn.TabIndex = 17;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            // 
            // selectBtn
            // 
            this.selectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.selectBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBtn.ForeColor = System.Drawing.Color.White;
            this.selectBtn.Location = new System.Drawing.Point(10, 405);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(105, 30);
            this.selectBtn.TabIndex = 16;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = false;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "All",
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(11, 375);
            this.genderComboBox.MaxDropDownItems = 12;
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(225, 24);
            this.genderComboBox.TabIndex = 15;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.genderLabel.Location = new System.Drawing.Point(8, 355);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(63, 17);
            this.genderLabel.TabIndex = 14;
            this.genderLabel.Text = "GENDER:";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dobLabel.Location = new System.Drawing.Point(8, 310);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(108, 17);
            this.dobLabel.TabIndex = 12;
            this.dobLabel.Text = "DATE OF BIRTH:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(11, 285);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(225, 22);
            this.emailTextBox.TabIndex = 11;
            this.emailTextBox.Tag = "";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.emailLabel.Location = new System.Drawing.Point(8, 265);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(51, 17);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "EMAIL:";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(11, 240);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(225, 22);
            this.contactTextBox.TabIndex = 9;
            this.contactTextBox.Tag = "";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.contactLabel.Location = new System.Drawing.Point(8, 220);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(72, 17);
            this.contactLabel.TabIndex = 8;
            this.contactLabel.Text = "CONTACT:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(11, 105);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(225, 22);
            this.lastNameTextBox.TabIndex = 7;
            this.lastNameTextBox.Tag = "";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lastNameLabel.Location = new System.Drawing.Point(8, 85);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(85, 17);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "LAST NAME:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(11, 60);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(225, 22);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.firstNameLabel.Location = new System.Drawing.Point(8, 40);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(88, 17);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "FIRST NAME:";
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
            this.formLabel.Size = new System.Drawing.Size(124, 23);
            this.formLabel.TabIndex = 0;
            this.formLabel.Text = "Select Advisor";
            // 
            // AdvisoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "AdvisoryControl";
            this.Size = new System.Drawing.Size(858, 580);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.gridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advisorListGrid)).EndInit();
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
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button exportAdvisorBtn;
        private System.Windows.Forms.Button importAdvisorBtn;
        private System.Windows.Forms.Button deleteAdvisorBtn;
        private System.Windows.Forms.Button addAdvisorBtn;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Panel saperator;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.DataGridView advisorListGrid;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.ComboBox designationComboBox;
        private System.Windows.Forms.Label designationLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editColumn;
        private System.Windows.Forms.ComboBox designationComboBox;
    }
}
