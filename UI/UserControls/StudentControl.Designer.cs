using System.Windows.Forms;


namespace MidDb26_2025CS127.UI.UserControls
{
    partial class StudentControl
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
            this.studentListGrid = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.exportStudentBtn = new System.Windows.Forms.Button();
            this.importStudentBtn = new System.Windows.Forms.Button();
            this.deleteStudentBtn = new System.Windows.Forms.Button();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.formPanel = new System.Windows.Forms.Panel();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
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
            this.regNoTextBox = new System.Windows.Forms.TextBox();
            this.regLabel = new System.Windows.Forms.Label();
            this.saperator = new System.Windows.Forms.Panel();
            this.formLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.gridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentListGrid)).BeginInit();
            this.actionPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.subtitleLabel);
            this.headerPanel.Controls.Add(this.breadcrumbLabel);
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Controls.Add(this.accentBar);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.headerPanel.Size = new System.Drawing.Size(859, 95);
            this.headerPanel.TabIndex = 1;
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.subtitleLabel.Location = new System.Drawing.Point(22, 70);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(252, 20);
            this.subtitleLabel.TabIndex = 3;
            this.subtitleLabel.Text = "Add, view, edit and remove students.";
            // 
            // breadcrumbLabel
            // 
            this.breadcrumbLabel.AutoSize = true;
            this.breadcrumbLabel.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breadcrumbLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.breadcrumbLabel.Location = new System.Drawing.Point(25, 8);
            this.breadcrumbLabel.Name = "breadcrumbLabel";
            this.breadcrumbLabel.Size = new System.Drawing.Size(102, 15);
            this.breadcrumbLabel.TabIndex = 2;
            this.breadcrumbLabel.Text = "Home  ›  Students";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.titleLabel.Location = new System.Drawing.Point(17, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(358, 45);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Student Management";
            // 
            // accentBar
            // 
            this.accentBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
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
            this.mainPanel.Size = new System.Drawing.Size(859, 448);
            this.mainPanel.TabIndex = 2;
            // 
            // gridContainer
            // 
            this.gridContainer.ColumnCount = 1;
            this.gridContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gridContainer.Controls.Add(this.studentListGrid, 0, 0);
            this.gridContainer.Controls.Add(this.actionPanel, 0, 1);
            this.gridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContainer.Location = new System.Drawing.Point(3, 3);
            this.gridContainer.Name = "gridContainer";
            this.gridContainer.RowCount = 2;
            this.gridContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gridContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.gridContainer.Size = new System.Drawing.Size(602, 442);
            this.gridContainer.TabIndex = 0;
            this.gridContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.gridContainer_Paint);
            // 
            // studentListGrid
            // 
            this.studentListGrid.AllowUserToAddRows = false;
            this.studentListGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.studentListGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.studentListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.studentListGrid.BackgroundColor = System.Drawing.Color.White;
            this.studentListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentListGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.studentListGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.studentListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.regColumn,
            this.firstNameColumn,
            this.lastNameColumn,
            this.contactColumn,
            this.emailColumn,
            this.dobColumn,
            this.genderColumn,
            this.editColumn,
            this.deleteColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentListGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.studentListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentListGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.studentListGrid.Location = new System.Drawing.Point(3, 3);
            this.studentListGrid.Name = "studentListGrid";
            this.studentListGrid.ReadOnly = true;
            this.studentListGrid.RowHeadersVisible = false;
            this.studentListGrid.RowHeadersWidth = 51;
            this.studentListGrid.RowTemplate.Height = 24;
            this.studentListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.studentListGrid.Size = new System.Drawing.Size(596, 381);
            this.studentListGrid.TabIndex = 6;
            this.studentListGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentListGrid_CellContentClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "id";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            this.idColumn.Width = 38;
            // 
            // regColumn
            // 
            this.regColumn.FillWeight = 80F;
            this.regColumn.HeaderText = "Reg No";
            this.regColumn.MinimumWidth = 4;
            this.regColumn.Name = "regColumn";
            this.regColumn.ReadOnly = true;
            // 
            // firstNameColumn
            // 
            this.firstNameColumn.HeaderText = "First Name";
            this.firstNameColumn.MinimumWidth = 6;
            this.firstNameColumn.Name = "firstNameColumn";
            this.firstNameColumn.ReadOnly = true;
            this.firstNameColumn.Width = 125;
            // 
            // lastNameColumn
            // 
            this.lastNameColumn.HeaderText = "Last Name";
            this.lastNameColumn.MinimumWidth = 6;
            this.lastNameColumn.Name = "lastNameColumn";
            this.lastNameColumn.ReadOnly = true;
            this.lastNameColumn.Width = 123;
            // 
            // contactColumn
            // 
            this.contactColumn.HeaderText = "Contact";
            this.contactColumn.MinimumWidth = 6;
            this.contactColumn.Name = "contactColumn";
            this.contactColumn.ReadOnly = true;
            this.contactColumn.Width = 102;
            // 
            // emailColumn
            // 
            this.emailColumn.HeaderText = "Email";
            this.emailColumn.MinimumWidth = 6;
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.ReadOnly = true;
            this.emailColumn.Width = 86;
            // 
            // dobColumn
            // 
            this.dobColumn.HeaderText = "Date of Birth";
            this.dobColumn.MinimumWidth = 6;
            this.dobColumn.Name = "dobColumn";
            this.dobColumn.ReadOnly = true;
            this.dobColumn.Width = 139;
            // 
            // genderColumn
            // 
            this.genderColumn.HeaderText = "Gender";
            this.genderColumn.MinimumWidth = 6;
            this.genderColumn.Name = "genderColumn";
            this.genderColumn.ReadOnly = true;
            this.genderColumn.Width = 99;
            // 
            // editColumn
            // 
            this.editColumn.HeaderText = "Edit";
            this.editColumn.MinimumWidth = 6;
            this.editColumn.Name = "editColumn";
            this.editColumn.ReadOnly = true;
            this.editColumn.Text = "Edit";
            this.editColumn.ToolTipText = "Edit student";
            this.editColumn.UseColumnTextForButtonValue = true;
            this.editColumn.Width = 52;
            // 
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "Delete";
            this.deleteColumn.MinimumWidth = 6;
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            this.deleteColumn.Text = "Delete";
            this.deleteColumn.ToolTipText = "Delete student from database.";
            this.deleteColumn.UseColumnTextForButtonValue = true;
            this.deleteColumn.Width = 70;
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.exportStudentBtn);
            this.actionPanel.Controls.Add(this.importStudentBtn);
            this.actionPanel.Controls.Add(this.deleteStudentBtn);
            this.actionPanel.Controls.Add(this.addStudentBtn);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionPanel.Location = new System.Drawing.Point(3, 390);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(596, 49);
            this.actionPanel.TabIndex = 5;
            // 
            // exportStudentBtn
            // 
            this.exportStudentBtn.BackColor = System.Drawing.Color.White;
            this.exportStudentBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportStudentBtn.ForeColor = System.Drawing.Color.Black;
            this.exportStudentBtn.Location = new System.Drawing.Point(448, 9);
            this.exportStudentBtn.Name = "exportStudentBtn";
            this.exportStudentBtn.Size = new System.Drawing.Size(136, 30);
            this.exportStudentBtn.TabIndex = 3;
            this.exportStudentBtn.Text = "Export Selected";
            this.exportStudentBtn.UseVisualStyleBackColor = false;
            // 
            // importStudentBtn
            // 
            this.importStudentBtn.BackColor = System.Drawing.Color.White;
            this.importStudentBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importStudentBtn.ForeColor = System.Drawing.Color.Black;
            this.importStudentBtn.Location = new System.Drawing.Point(371, 9);
            this.importStudentBtn.Name = "importStudentBtn";
            this.importStudentBtn.Size = new System.Drawing.Size(72, 30);
            this.importStudentBtn.TabIndex = 2;
            this.importStudentBtn.Text = "Import";
            this.importStudentBtn.UseVisualStyleBackColor = false;
            // 
            // deleteStudentBtn
            // 
            this.deleteStudentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.deleteStudentBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteStudentBtn.ForeColor = System.Drawing.Color.White;
            this.deleteStudentBtn.Location = new System.Drawing.Point(181, 9);
            this.deleteStudentBtn.Name = "deleteStudentBtn";
            this.deleteStudentBtn.Size = new System.Drawing.Size(155, 30);
            this.deleteStudentBtn.TabIndex = 1;
            this.deleteStudentBtn.Text = "Delete Selected";
            this.deleteStudentBtn.UseVisualStyleBackColor = false;
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.addStudentBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentBtn.ForeColor = System.Drawing.Color.White;
            this.addStudentBtn.Location = new System.Drawing.Point(11, 10);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(155, 30);
            this.addStudentBtn.TabIndex = 0;
            this.addStudentBtn.Text = "Add Student";
            this.addStudentBtn.UseVisualStyleBackColor = false;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // formPanel
            // 
            this.formPanel.Controls.Add(this.dobPicker);
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
            this.formPanel.Controls.Add(this.regNoTextBox);
            this.formPanel.Controls.Add(this.regLabel);
            this.formPanel.Controls.Add(this.saperator);
            this.formPanel.Controls.Add(this.formLabel);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(611, 3);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(245, 442);
            this.formPanel.TabIndex = 1;
            // 
            // dobPicker
            // 
            this.dobPicker.Checked = false;
            this.dobPicker.Location = new System.Drawing.Point(11, 285);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.ShowCheckBox = true;
            this.dobPicker.Size = new System.Drawing.Size(225, 22);
            this.dobPicker.TabIndex = 18;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.White;
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.Location = new System.Drawing.Point(122, 361);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(72, 30);
            this.clearBtn.TabIndex = 17;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.selectBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBtn.ForeColor = System.Drawing.Color.White;
            this.selectBtn.Location = new System.Drawing.Point(11, 361);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(105, 30);
            this.selectBtn.TabIndex = 16;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = false;
            // 
            // genderComboBox
            // 
            this.genderComboBox.BackColor = System.Drawing.Color.White;
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "All",
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(11, 330);
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
            this.genderLabel.Location = new System.Drawing.Point(8, 310);
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
            this.dobLabel.Location = new System.Drawing.Point(8, 265);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(108, 17);
            this.dobLabel.TabIndex = 12;
            this.dobLabel.Text = "DATE OF BIRTH:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(11, 240);
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
            this.emailLabel.Location = new System.Drawing.Point(8, 220);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(51, 17);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "EMAIL:";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(11, 195);
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
            this.contactLabel.Location = new System.Drawing.Point(11, 175);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(72, 17);
            this.contactLabel.TabIndex = 8;
            this.contactLabel.Text = "CONTACT:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(11, 150);
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
            this.lastNameLabel.Location = new System.Drawing.Point(8, 130);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(85, 17);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "LAST NAME:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(11, 105);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(225, 22);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.firstNameLabel.Location = new System.Drawing.Point(8, 85);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(88, 17);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "FIRST NAME:";
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Location = new System.Drawing.Point(11, 60);
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.Size = new System.Drawing.Size(225, 22);
            this.regNoTextBox.TabIndex = 3;
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.regLabel.Location = new System.Drawing.Point(8, 39);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(134, 17);
            this.regLabel.TabIndex = 2;
            this.regLabel.Text = "REGISTERATION NO:";
            // 
            // saperator
            // 
            this.saperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saperator.Location = new System.Drawing.Point(3, 29);
            this.saperator.Name = "saperator";
            this.saperator.Size = new System.Drawing.Size(233, 3);
            this.saperator.TabIndex = 1;
            this.saperator.Paint += new System.Windows.Forms.PaintEventHandler(this.saperator_Paint);
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLabel.Location = new System.Drawing.Point(4, 4);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(127, 23);
            this.formLabel.TabIndex = 0;
            this.formLabel.Text = "Select Student";
            // 
            // StudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "StudentControl";
            this.Size = new System.Drawing.Size(859, 543);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.gridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentListGrid)).EndInit();
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
        private Panel formPanel;
        private Panel saperator;
        private Label formLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private TextBox regNoTextBox;
        private Label regLabel;
        private Label dobLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox contactTextBox;
        private Label contactLabel;
        private ComboBox genderComboBox;
        private Label genderLabel;
        private Button clearBtn;
        private Button selectBtn;
        private DateTimePicker dobPicker;
        private TableLayoutPanel gridContainer;
        private DataGridView studentListGrid;
        private Panel actionPanel;
        private Button exportStudentBtn;
        private Button importStudentBtn;
        private Button deleteStudentBtn;
        private Button addStudentBtn;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn regColumn;
        private DataGridViewTextBoxColumn firstNameColumn;
        private DataGridViewTextBoxColumn lastNameColumn;
        private DataGridViewTextBoxColumn contactColumn;
        private DataGridViewTextBoxColumn emailColumn;
        private DataGridViewTextBoxColumn dobColumn;
        private DataGridViewTextBoxColumn genderColumn;
        private DataGridViewButtonColumn editColumn;
        private DataGridViewButtonColumn deleteColumn;
    }
}
