namespace MidDb26_2025CS127.UI.Froms
{
    partial class AddGroupForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGroupForm));
            this.containerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainBodyPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupDetailPanel = new System.Windows.Forms.Panel();
            this.bottomLine = new System.Windows.Forms.Panel();
            this.middleLine = new System.Windows.Forms.Panel();
            this.projectLabel = new System.Windows.Forms.Label();
            this.projectComboBox = new System.Windows.Forms.ComboBox();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.studentDetailPanel = new System.Windows.Forms.TableLayoutPanel();
            this.studentDetailBodyPanel = new System.Windows.Forms.Panel();
            this.selectedStudentLabel = new System.Windows.Forms.Label();
            this.selectedStudentPanel = new System.Windows.Forms.Panel();
            this.selectedStudent1Panel = new System.Windows.Forms.Panel();
            this.selectedStudent1RemoveBtn = new System.Windows.Forms.Button();
            this.selectedStudent1Label = new System.Windows.Forms.Label();
            this.arrowLabel = new System.Windows.Forms.Label();
            this.unassignedStudentsList = new System.Windows.Forms.ListBox();
            this.unassignedStudentsLabel = new System.Windows.Forms.Label();
            this.studentDetailFooterPanel = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.selectedStudent1activeBtn = new System.Windows.Forms.Button();
            this.selectedStudent2Panel = new System.Windows.Forms.Panel();
            this.selectedStudent2ActiveBtn = new System.Windows.Forms.Button();
            this.selectedStudent2RemoveBtn = new System.Windows.Forms.Button();
            this.selectedStudent2Label = new System.Windows.Forms.Label();
            this.containerPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.mainBodyPanel.SuspendLayout();
            this.groupDetailPanel.SuspendLayout();
            this.studentDetailPanel.SuspendLayout();
            this.studentDetailBodyPanel.SuspendLayout();
            this.selectedStudentPanel.SuspendLayout();
            this.selectedStudent1Panel.SuspendLayout();
            this.studentDetailFooterPanel.SuspendLayout();
            this.selectedStudent2Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.ColumnCount = 1;
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.containerPanel.Controls.Add(this.headerPanel, 0, 0);
            this.containerPanel.Controls.Add(this.mainBodyPanel, 0, 1);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.RowCount = 2;
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.containerPanel.Size = new System.Drawing.Size(982, 403);
            this.containerPanel.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(3, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(976, 49);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.titleLabel.Location = new System.Drawing.Point(395, 3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(188, 45);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Add Group";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // mainBodyPanel
            // 
            this.mainBodyPanel.ColumnCount = 2;
            this.mainBodyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.mainBodyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainBodyPanel.Controls.Add(this.groupDetailPanel, 0, 0);
            this.mainBodyPanel.Controls.Add(this.studentDetailPanel, 1, 0);
            this.mainBodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBodyPanel.Location = new System.Drawing.Point(3, 58);
            this.mainBodyPanel.Name = "mainBodyPanel";
            this.mainBodyPanel.RowCount = 1;
            this.mainBodyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainBodyPanel.Size = new System.Drawing.Size(976, 342);
            this.mainBodyPanel.TabIndex = 1;
            // 
            // groupDetailPanel
            // 
            this.groupDetailPanel.Controls.Add(this.bottomLine);
            this.groupDetailPanel.Controls.Add(this.middleLine);
            this.groupDetailPanel.Controls.Add(this.projectLabel);
            this.groupDetailPanel.Controls.Add(this.projectComboBox);
            this.groupDetailPanel.Controls.Add(this.groupNameTextBox);
            this.groupDetailPanel.Controls.Add(this.groupNameLabel);
            this.groupDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDetailPanel.Location = new System.Drawing.Point(3, 3);
            this.groupDetailPanel.Name = "groupDetailPanel";
            this.groupDetailPanel.Size = new System.Drawing.Size(344, 336);
            this.groupDetailPanel.TabIndex = 0;
            // 
            // bottomLine
            // 
            this.bottomLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.bottomLine.Location = new System.Drawing.Point(-3, 280);
            this.bottomLine.Name = "bottomLine";
            this.bottomLine.Size = new System.Drawing.Size(366, 5);
            this.bottomLine.TabIndex = 56;
            // 
            // middleLine
            // 
            this.middleLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.middleLine.Location = new System.Drawing.Point(338, -282);
            this.middleLine.Name = "middleLine";
            this.middleLine.Size = new System.Drawing.Size(5, 900);
            this.middleLine.TabIndex = 55;
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.projectLabel.Location = new System.Drawing.Point(15, 121);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(105, 20);
            this.projectLabel.TabIndex = 3;
            this.projectLabel.Text = "Select Project:";
            // 
            // projectComboBox
            // 
            this.projectComboBox.FormattingEnabled = true;
            this.projectComboBox.Location = new System.Drawing.Point(127, 121);
            this.projectComboBox.Name = "projectComboBox";
            this.projectComboBox.Size = new System.Drawing.Size(186, 24);
            this.projectComboBox.TabIndex = 2;
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.Location = new System.Drawing.Point(123, 37);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(191, 22);
            this.groupNameTextBox.TabIndex = 1;
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupNameLabel.Location = new System.Drawing.Point(15, 37);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(101, 20);
            this.groupNameLabel.TabIndex = 0;
            this.groupNameLabel.Text = "Group Name:";
            // 
            // studentDetailPanel
            // 
            this.studentDetailPanel.ColumnCount = 1;
            this.studentDetailPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentDetailPanel.Controls.Add(this.studentDetailBodyPanel, 0, 0);
            this.studentDetailPanel.Controls.Add(this.studentDetailFooterPanel, 0, 1);
            this.studentDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentDetailPanel.Location = new System.Drawing.Point(353, 3);
            this.studentDetailPanel.Name = "studentDetailPanel";
            this.studentDetailPanel.RowCount = 2;
            this.studentDetailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.04663F));
            this.studentDetailPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.95337F));
            this.studentDetailPanel.Size = new System.Drawing.Size(620, 336);
            this.studentDetailPanel.TabIndex = 1;
            // 
            // studentDetailBodyPanel
            // 
            this.studentDetailBodyPanel.Controls.Add(this.unassignedStudentsList);
            this.studentDetailBodyPanel.Controls.Add(this.selectedStudentLabel);
            this.studentDetailBodyPanel.Controls.Add(this.selectedStudentPanel);
            this.studentDetailBodyPanel.Controls.Add(this.arrowLabel);
            this.studentDetailBodyPanel.Controls.Add(this.unassignedStudentsLabel);
            this.studentDetailBodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentDetailBodyPanel.Location = new System.Drawing.Point(3, 3);
            this.studentDetailBodyPanel.Name = "studentDetailBodyPanel";
            this.studentDetailBodyPanel.Size = new System.Drawing.Size(614, 286);
            this.studentDetailBodyPanel.TabIndex = 0;
            // 
            // selectedStudentLabel
            // 
            this.selectedStudentLabel.AutoSize = true;
            this.selectedStudentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedStudentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectedStudentLabel.Location = new System.Drawing.Point(226, 36);
            this.selectedStudentLabel.Name = "selectedStudentLabel";
            this.selectedStudentLabel.Size = new System.Drawing.Size(133, 20);
            this.selectedStudentLabel.TabIndex = 5;
            this.selectedStudentLabel.Text = "Selected Students:";
            // 
            // selectedStudentPanel
            // 
            this.selectedStudentPanel.AutoScroll = true;
            this.selectedStudentPanel.BackColor = System.Drawing.Color.White;
            this.selectedStudentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedStudentPanel.Controls.Add(this.selectedStudent2Panel);
            this.selectedStudentPanel.Controls.Add(this.selectedStudent1Panel);
            this.selectedStudentPanel.Location = new System.Drawing.Point(230, 59);
            this.selectedStudentPanel.Name = "selectedStudentPanel";
            this.selectedStudentPanel.Size = new System.Drawing.Size(369, 180);
            this.selectedStudentPanel.TabIndex = 4;
            // 
            // selectedStudent1Panel
            // 
            this.selectedStudent1Panel.Controls.Add(this.selectedStudent1activeBtn);
            this.selectedStudent1Panel.Controls.Add(this.selectedStudent1RemoveBtn);
            this.selectedStudent1Panel.Controls.Add(this.selectedStudent1Label);
            this.selectedStudent1Panel.Location = new System.Drawing.Point(4, 4);
            this.selectedStudent1Panel.Name = "selectedStudent1Panel";
            this.selectedStudent1Panel.Size = new System.Drawing.Size(360, 40);
            this.selectedStudent1Panel.TabIndex = 0;
            // 
            // selectedStudent1RemoveBtn
            // 
            this.selectedStudent1RemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.selectedStudent1RemoveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedStudent1RemoveBtn.ForeColor = System.Drawing.Color.White;
            this.selectedStudent1RemoveBtn.Location = new System.Drawing.Point(279, 5);
            this.selectedStudent1RemoveBtn.Name = "selectedStudent1RemoveBtn";
            this.selectedStudent1RemoveBtn.Size = new System.Drawing.Size(78, 30);
            this.selectedStudent1RemoveBtn.TabIndex = 35;
            this.selectedStudent1RemoveBtn.Text = "Remove";
            this.selectedStudent1RemoveBtn.UseVisualStyleBackColor = false;
            this.selectedStudent1RemoveBtn.Click += new System.EventHandler(this.selectedStudent1RemoveBtn_Click);
            // 
            // selectedStudent1Label
            // 
            this.selectedStudent1Label.AutoSize = true;
            this.selectedStudent1Label.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedStudent1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.selectedStudent1Label.Location = new System.Drawing.Point(3, 8);
            this.selectedStudent1Label.Name = "selectedStudent1Label";
            this.selectedStudent1Label.Size = new System.Drawing.Size(82, 23);
            this.selectedStudent1Label.TabIndex = 0;
            this.selectedStudent1Label.Text = "student11";
            // 
            // arrowLabel
            // 
            this.arrowLabel.AutoSize = true;
            this.arrowLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.arrowLabel.Location = new System.Drawing.Point(179, 91);
            this.arrowLabel.Name = "arrowLabel";
            this.arrowLabel.Size = new System.Drawing.Size(58, 54);
            this.arrowLabel.TabIndex = 3;
            this.arrowLabel.Text = "→";
            // 
            // unassignedStudentsList
            // 
            this.unassignedStudentsList.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unassignedStudentsList.FormattingEnabled = true;
            this.unassignedStudentsList.ItemHeight = 23;
            this.unassignedStudentsList.Items.AddRange(new object[] {
            "s1",
            "s2",
            "s3",
            "s4",
            "s5",
            "s6",
            "s7",
            "s8",
            "s9"});
            this.unassignedStudentsList.Location = new System.Drawing.Point(35, 59);
            this.unassignedStudentsList.Name = "unassignedStudentsList";
            this.unassignedStudentsList.Size = new System.Drawing.Size(151, 165);
            this.unassignedStudentsList.TabIndex = 2;
            // 
            // unassignedStudentsLabel
            // 
            this.unassignedStudentsLabel.AutoSize = true;
            this.unassignedStudentsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unassignedStudentsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.unassignedStudentsLabel.Location = new System.Drawing.Point(15, 36);
            this.unassignedStudentsLabel.Name = "unassignedStudentsLabel";
            this.unassignedStudentsLabel.Size = new System.Drawing.Size(155, 20);
            this.unassignedStudentsLabel.TabIndex = 1;
            this.unassignedStudentsLabel.Text = "Unassigned Students:";
            // 
            // studentDetailFooterPanel
            // 
            this.studentDetailFooterPanel.Controls.Add(this.cancelBtn);
            this.studentDetailFooterPanel.Controls.Add(this.saveBtn);
            this.studentDetailFooterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentDetailFooterPanel.Location = new System.Drawing.Point(3, 295);
            this.studentDetailFooterPanel.Name = "studentDetailFooterPanel";
            this.studentDetailFooterPanel.Size = new System.Drawing.Size(614, 38);
            this.studentDetailFooterPanel.TabIndex = 1;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(338, 7);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(72, 30);
            this.cancelBtn.TabIndex = 35;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(202, 7);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(105, 30);
            this.saveBtn.TabIndex = 34;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // selectedStudent1activeBtn
            // 
            this.selectedStudent1activeBtn.BackColor = System.Drawing.Color.White;
            this.selectedStudent1activeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedStudent1activeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectedStudent1activeBtn.Location = new System.Drawing.Point(188, 5);
            this.selectedStudent1activeBtn.Name = "selectedStudent1activeBtn";
            this.selectedStudent1activeBtn.Size = new System.Drawing.Size(88, 30);
            this.selectedStudent1activeBtn.TabIndex = 36;
            this.selectedStudent1activeBtn.Text = "Inactivate";
            this.selectedStudent1activeBtn.UseVisualStyleBackColor = false;
            // 
            // selectedStudent2Panel
            // 
            this.selectedStudent2Panel.Controls.Add(this.selectedStudent2ActiveBtn);
            this.selectedStudent2Panel.Controls.Add(this.selectedStudent2RemoveBtn);
            this.selectedStudent2Panel.Controls.Add(this.selectedStudent2Label);
            this.selectedStudent2Panel.Location = new System.Drawing.Point(4, 45);
            this.selectedStudent2Panel.Name = "selectedStudent2Panel";
            this.selectedStudent2Panel.Size = new System.Drawing.Size(360, 40);
            this.selectedStudent2Panel.TabIndex = 37;
            // 
            // selectedStudent2ActiveBtn
            // 
            this.selectedStudent2ActiveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.selectedStudent2ActiveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedStudent2ActiveBtn.ForeColor = System.Drawing.Color.White;
            this.selectedStudent2ActiveBtn.Location = new System.Drawing.Point(188, 5);
            this.selectedStudent2ActiveBtn.Name = "selectedStudent2ActiveBtn";
            this.selectedStudent2ActiveBtn.Size = new System.Drawing.Size(88, 30);
            this.selectedStudent2ActiveBtn.TabIndex = 36;
            this.selectedStudent2ActiveBtn.Text = "Activate";
            this.selectedStudent2ActiveBtn.UseVisualStyleBackColor = false;
            // 
            // selectedStudent2RemoveBtn
            // 
            this.selectedStudent2RemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.selectedStudent2RemoveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedStudent2RemoveBtn.ForeColor = System.Drawing.Color.White;
            this.selectedStudent2RemoveBtn.Location = new System.Drawing.Point(279, 5);
            this.selectedStudent2RemoveBtn.Name = "selectedStudent2RemoveBtn";
            this.selectedStudent2RemoveBtn.Size = new System.Drawing.Size(78, 30);
            this.selectedStudent2RemoveBtn.TabIndex = 35;
            this.selectedStudent2RemoveBtn.Text = "Remove";
            this.selectedStudent2RemoveBtn.UseVisualStyleBackColor = false;
            // 
            // selectedStudent2Label
            // 
            this.selectedStudent2Label.AutoSize = true;
            this.selectedStudent2Label.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedStudent2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectedStudent2Label.Location = new System.Drawing.Point(3, 8);
            this.selectedStudent2Label.Name = "selectedStudent2Label";
            this.selectedStudent2Label.Size = new System.Drawing.Size(82, 23);
            this.selectedStudent2Label.TabIndex = 0;
            this.selectedStudent2Label.Text = "student11";
            // 
            // AddGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(982, 403);
            this.Controls.Add(this.containerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 450);
            this.MinimumSize = new System.Drawing.Size(1000, 450);
            this.Name = "AddGroupForm";
            this.Text = "Add Group";
            this.containerPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainBodyPanel.ResumeLayout(false);
            this.groupDetailPanel.ResumeLayout(false);
            this.groupDetailPanel.PerformLayout();
            this.studentDetailPanel.ResumeLayout(false);
            this.studentDetailBodyPanel.ResumeLayout(false);
            this.studentDetailBodyPanel.PerformLayout();
            this.selectedStudentPanel.ResumeLayout(false);
            this.selectedStudent1Panel.ResumeLayout(false);
            this.selectedStudent1Panel.PerformLayout();
            this.studentDetailFooterPanel.ResumeLayout(false);
            this.selectedStudent2Panel.ResumeLayout(false);
            this.selectedStudent2Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel containerPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TableLayoutPanel mainBodyPanel;
        private System.Windows.Forms.Panel groupDetailPanel;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.ComboBox projectComboBox;
        private System.Windows.Forms.TableLayoutPanel studentDetailPanel;
        private System.Windows.Forms.Panel studentDetailBodyPanel;
        private System.Windows.Forms.Panel studentDetailFooterPanel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label unassignedStudentsLabel;
        private System.Windows.Forms.Label selectedStudentLabel;
        private System.Windows.Forms.Panel selectedStudentPanel;
        private System.Windows.Forms.Label arrowLabel;
        private System.Windows.Forms.ListBox unassignedStudentsList;
        private System.Windows.Forms.Panel selectedStudent1Panel;
        private System.Windows.Forms.Button selectedStudent1RemoveBtn;
        private System.Windows.Forms.Label selectedStudent1Label;
        private System.Windows.Forms.Panel bottomLine;
        private System.Windows.Forms.Panel middleLine;
        private System.Windows.Forms.Button selectedStudent1activeBtn;
        private System.Windows.Forms.Panel selectedStudent2Panel;
        private System.Windows.Forms.Button selectedStudent2ActiveBtn;
        private System.Windows.Forms.Button selectedStudent2RemoveBtn;
        private System.Windows.Forms.Label selectedStudent2Label;
    }
}