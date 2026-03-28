namespace MidDb26_2025CS127.UI.UserControls
{
    partial class EvaluationControl
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.breadcrumbLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.accentBar = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gridHeader = new System.Windows.Forms.Panel();
            this.selectEvaluationComboBox = new System.Windows.Forms.ComboBox();
            this.selectEvaluationLabel = new System.Windows.Forms.Label();
            this.gridHeaderLabel = new System.Windows.Forms.Label();
            this.evaluationBodyPanel = new System.Windows.Forms.TableLayoutPanel();
            this.evaluationDetailPanel = new System.Windows.Forms.Panel();
            this.weightageValueLabel = new System.Windows.Forms.Label();
            this.weightageLabel = new System.Windows.Forms.Label();
            this.totalMarksValueLabel = new System.Windows.Forms.Label();
            this.totalMarksLabel = new System.Windows.Forms.Label();
            this.underline = new System.Windows.Forms.Panel();
            this.evaluationNameLabel = new System.Windows.Forms.Label();
            this.markSheetPanel = new System.Windows.Forms.TableLayoutPanel();
            this.markSheet = new System.Windows.Forms.DataGridView();
            this.group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obtainedMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksSheetHeader = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.exportMarksBtn = new System.Windows.Forms.Button();
            this.enterMarksBtn = new System.Windows.Forms.Button();
            this.addEvaluationBtn = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.gridHeader.SuspendLayout();
            this.evaluationBodyPanel.SuspendLayout();
            this.evaluationDetailPanel.SuspendLayout();
            this.markSheetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markSheet)).BeginInit();
            this.buttonsPanel.SuspendLayout();
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
            this.headerPanel.Size = new System.Drawing.Size(757, 95);
            this.headerPanel.TabIndex = 1;
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.subtitleLabel.Location = new System.Drawing.Point(22, 70);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(316, 20);
            this.subtitleLabel.TabIndex = 3;
            this.subtitleLabel.Text = "Manage evaluations and marks for each group";
            // 
            // breadcrumbLabel
            // 
            this.breadcrumbLabel.AutoSize = true;
            this.breadcrumbLabel.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breadcrumbLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.breadcrumbLabel.Location = new System.Drawing.Point(25, 8);
            this.breadcrumbLabel.Name = "breadcrumbLabel";
            this.breadcrumbLabel.Size = new System.Drawing.Size(116, 15);
            this.breadcrumbLabel.TabIndex = 2;
            this.breadcrumbLabel.Text = "Home  ›  Evaluations";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.titleLabel.Location = new System.Drawing.Point(17, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(180, 45);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Evalutions";
            // 
            // accentBar
            // 
            this.accentBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.accentBar.Location = new System.Drawing.Point(0, 8);
            this.accentBar.Name = "accentBar";
            this.accentBar.Size = new System.Drawing.Size(4, 75);
            this.accentBar.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.gridHeader, 0, 0);
            this.mainPanel.Controls.Add(this.evaluationBodyPanel, 0, 1);
            this.mainPanel.Controls.Add(this.buttonsPanel, 0, 2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 95);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 3;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.mainPanel.Size = new System.Drawing.Size(757, 462);
            this.mainPanel.TabIndex = 2;
            // 
            // gridHeader
            // 
            this.gridHeader.BackColor = System.Drawing.Color.White;
            this.gridHeader.Controls.Add(this.selectEvaluationComboBox);
            this.gridHeader.Controls.Add(this.selectEvaluationLabel);
            this.gridHeader.Controls.Add(this.gridHeaderLabel);
            this.gridHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHeader.Location = new System.Drawing.Point(3, 3);
            this.gridHeader.Name = "gridHeader";
            this.gridHeader.Size = new System.Drawing.Size(751, 39);
            this.gridHeader.TabIndex = 9;
            // 
            // selectEvaluationComboBox
            // 
            this.selectEvaluationComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.selectEvaluationComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.selectEvaluationComboBox.BackColor = System.Drawing.Color.White;
            this.selectEvaluationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectEvaluationComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectEvaluationComboBox.FormattingEnabled = true;
            this.selectEvaluationComboBox.Items.AddRange(new object[] {
            "Mid",
            "Viva",
            "Final"});
            this.selectEvaluationComboBox.Location = new System.Drawing.Point(476, 6);
            this.selectEvaluationComboBox.MaxDropDownItems = 12;
            this.selectEvaluationComboBox.Name = "selectEvaluationComboBox";
            this.selectEvaluationComboBox.Size = new System.Drawing.Size(165, 24);
            this.selectEvaluationComboBox.TabIndex = 3;
            this.selectEvaluationComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // selectEvaluationLabel
            // 
            this.selectEvaluationLabel.AutoSize = true;
            this.selectEvaluationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectEvaluationLabel.Location = new System.Drawing.Point(345, 8);
            this.selectEvaluationLabel.Name = "selectEvaluationLabel";
            this.selectEvaluationLabel.Size = new System.Drawing.Size(133, 20);
            this.selectEvaluationLabel.TabIndex = 2;
            this.selectEvaluationLabel.Text = "Select Evalutaion: ";
            // 
            // gridHeaderLabel
            // 
            this.gridHeaderLabel.AutoSize = true;
            this.gridHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridHeaderLabel.Location = new System.Drawing.Point(3, 7);
            this.gridHeaderLabel.Name = "gridHeaderLabel";
            this.gridHeaderLabel.Size = new System.Drawing.Size(100, 23);
            this.gridHeaderLabel.TabIndex = 1;
            this.gridHeaderLabel.Text = "Evaluations";
            // 
            // evaluationBodyPanel
            // 
            this.evaluationBodyPanel.ColumnCount = 2;
            this.evaluationBodyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.evaluationBodyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.evaluationBodyPanel.Controls.Add(this.evaluationDetailPanel, 0, 0);
            this.evaluationBodyPanel.Controls.Add(this.markSheetPanel, 1, 0);
            this.evaluationBodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.evaluationBodyPanel.Location = new System.Drawing.Point(3, 48);
            this.evaluationBodyPanel.Name = "evaluationBodyPanel";
            this.evaluationBodyPanel.RowCount = 1;
            this.evaluationBodyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.evaluationBodyPanel.Size = new System.Drawing.Size(751, 357);
            this.evaluationBodyPanel.TabIndex = 10;
            // 
            // evaluationDetailPanel
            // 
            this.evaluationDetailPanel.BackColor = System.Drawing.Color.Transparent;
            this.evaluationDetailPanel.Controls.Add(this.weightageValueLabel);
            this.evaluationDetailPanel.Controls.Add(this.weightageLabel);
            this.evaluationDetailPanel.Controls.Add(this.totalMarksValueLabel);
            this.evaluationDetailPanel.Controls.Add(this.totalMarksLabel);
            this.evaluationDetailPanel.Controls.Add(this.underline);
            this.evaluationDetailPanel.Controls.Add(this.evaluationNameLabel);
            this.evaluationDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.evaluationDetailPanel.Location = new System.Drawing.Point(3, 3);
            this.evaluationDetailPanel.Name = "evaluationDetailPanel";
            this.evaluationDetailPanel.Size = new System.Drawing.Size(194, 351);
            this.evaluationDetailPanel.TabIndex = 0;
            // 
            // weightageValueLabel
            // 
            this.weightageValueLabel.AutoSize = true;
            this.weightageValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightageValueLabel.Location = new System.Drawing.Point(102, 134);
            this.weightageValueLabel.Name = "weightageValueLabel";
            this.weightageValueLabel.Size = new System.Drawing.Size(39, 20);
            this.weightageValueLabel.TabIndex = 5;
            this.weightageValueLabel.Text = "40%";
            // 
            // weightageLabel
            // 
            this.weightageLabel.AutoSize = true;
            this.weightageLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.weightageLabel.Location = new System.Drawing.Point(8, 134);
            this.weightageLabel.Name = "weightageLabel";
            this.weightageLabel.Size = new System.Drawing.Size(87, 20);
            this.weightageLabel.TabIndex = 4;
            this.weightageLabel.Text = "Weightage:";
            // 
            // totalMarksValueLabel
            // 
            this.totalMarksValueLabel.AutoSize = true;
            this.totalMarksValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMarksValueLabel.Location = new System.Drawing.Point(102, 92);
            this.totalMarksValueLabel.Name = "totalMarksValueLabel";
            this.totalMarksValueLabel.Size = new System.Drawing.Size(31, 20);
            this.totalMarksValueLabel.TabIndex = 3;
            this.totalMarksValueLabel.Text = "100";
            // 
            // totalMarksLabel
            // 
            this.totalMarksLabel.AutoSize = true;
            this.totalMarksLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMarksLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.totalMarksLabel.Location = new System.Drawing.Point(8, 92);
            this.totalMarksLabel.Name = "totalMarksLabel";
            this.totalMarksLabel.Size = new System.Drawing.Size(92, 20);
            this.totalMarksLabel.TabIndex = 2;
            this.totalMarksLabel.Text = "Total Marks:";
            // 
            // underline
            // 
            this.underline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.underline.Location = new System.Drawing.Point(22, 67);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(200, 3);
            this.underline.TabIndex = 1;
            // 
            // evaluationNameLabel
            // 
            this.evaluationNameLabel.AutoSize = true;
            this.evaluationNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluationNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.evaluationNameLabel.Location = new System.Drawing.Point(20, 32);
            this.evaluationNameLabel.Name = "evaluationNameLabel";
            this.evaluationNameLabel.Size = new System.Drawing.Size(80, 38);
            this.evaluationNameLabel.TabIndex = 0;
            this.evaluationNameLabel.Text = "Final";
            // 
            // markSheetPanel
            // 
            this.markSheetPanel.ColumnCount = 1;
            this.markSheetPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.markSheetPanel.Controls.Add(this.markSheet, 0, 1);
            this.markSheetPanel.Controls.Add(this.marksSheetHeader, 0, 0);
            this.markSheetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.markSheetPanel.Location = new System.Drawing.Point(203, 3);
            this.markSheetPanel.Name = "markSheetPanel";
            this.markSheetPanel.RowCount = 2;
            this.markSheetPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.markSheetPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.markSheetPanel.Size = new System.Drawing.Size(545, 351);
            this.markSheetPanel.TabIndex = 1;
            // 
            // markSheet
            // 
            this.markSheet.BackgroundColor = System.Drawing.Color.White;
            this.markSheet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.markSheet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.markSheet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.markSheet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.markSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.markSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.group,
            this.project,
            this.evaluationDate,
            this.obtainedMarks,
            this.actions});
            this.markSheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.markSheet.Location = new System.Drawing.Point(3, 43);
            this.markSheet.Name = "markSheet";
            this.markSheet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.markSheet.RowHeadersVisible = false;
            this.markSheet.RowHeadersWidth = 51;
            this.markSheet.RowTemplate.Height = 24;
            this.markSheet.Size = new System.Drawing.Size(539, 305);
            this.markSheet.TabIndex = 0;
            // 
            // group
            // 
            this.group.HeaderText = "Group";
            this.group.MinimumWidth = 6;
            this.group.Name = "group";
            this.group.ReadOnly = true;
            this.group.Width = 125;
            // 
            // project
            // 
            this.project.HeaderText = "Project";
            this.project.MinimumWidth = 6;
            this.project.Name = "project";
            this.project.ReadOnly = true;
            this.project.Width = 125;
            // 
            // evaluationDate
            // 
            this.evaluationDate.HeaderText = "Evaluation Date";
            this.evaluationDate.MinimumWidth = 6;
            this.evaluationDate.Name = "evaluationDate";
            this.evaluationDate.ReadOnly = true;
            this.evaluationDate.Width = 125;
            // 
            // obtainedMarks
            // 
            this.obtainedMarks.HeaderText = "Obtained Marks";
            this.obtainedMarks.MinimumWidth = 6;
            this.obtainedMarks.Name = "obtainedMarks";
            this.obtainedMarks.ReadOnly = true;
            this.obtainedMarks.Width = 125;
            // 
            // actions
            // 
            this.actions.HeaderText = "Actions";
            this.actions.MinimumWidth = 6;
            this.actions.Name = "actions";
            this.actions.ReadOnly = true;
            this.actions.Width = 125;
            // 
            // marksSheetHeader
            // 
            this.marksSheetHeader.AutoSize = true;
            this.marksSheetHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marksSheetHeader.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marksSheetHeader.Location = new System.Drawing.Point(3, 0);
            this.marksSheetHeader.Name = "marksSheetHeader";
            this.marksSheetHeader.Size = new System.Drawing.Size(539, 40);
            this.marksSheetHeader.TabIndex = 1;
            this.marksSheetHeader.Text = "Marks Sheet -- Final";
            this.marksSheetHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.exportMarksBtn);
            this.buttonsPanel.Controls.Add(this.enterMarksBtn);
            this.buttonsPanel.Controls.Add(this.addEvaluationBtn);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsPanel.Location = new System.Drawing.Point(3, 411);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(751, 48);
            this.buttonsPanel.TabIndex = 11;
            // 
            // exportMarksBtn
            // 
            this.exportMarksBtn.BackColor = System.Drawing.Color.White;
            this.exportMarksBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportMarksBtn.ForeColor = System.Drawing.Color.Black;
            this.exportMarksBtn.Location = new System.Drawing.Point(518, 9);
            this.exportMarksBtn.Name = "exportMarksBtn";
            this.exportMarksBtn.Size = new System.Drawing.Size(155, 30);
            this.exportMarksBtn.TabIndex = 3;
            this.exportMarksBtn.Text = "Export Marks";
            this.exportMarksBtn.UseVisualStyleBackColor = false;
            // 
            // enterMarksBtn
            // 
            this.enterMarksBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.enterMarksBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterMarksBtn.ForeColor = System.Drawing.Color.White;
            this.enterMarksBtn.Location = new System.Drawing.Point(180, 9);
            this.enterMarksBtn.Name = "enterMarksBtn";
            this.enterMarksBtn.Size = new System.Drawing.Size(155, 30);
            this.enterMarksBtn.TabIndex = 2;
            this.enterMarksBtn.Text = "Enter Marks";
            this.enterMarksBtn.UseVisualStyleBackColor = false;
            this.enterMarksBtn.Click += new System.EventHandler(this.enterMarksBtn_Click);
            // 
            // addEvaluationBtn
            // 
            this.addEvaluationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.addEvaluationBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvaluationBtn.ForeColor = System.Drawing.Color.White;
            this.addEvaluationBtn.Location = new System.Drawing.Point(14, 9);
            this.addEvaluationBtn.Name = "addEvaluationBtn";
            this.addEvaluationBtn.Size = new System.Drawing.Size(155, 30);
            this.addEvaluationBtn.TabIndex = 1;
            this.addEvaluationBtn.Text = "Add Evaluation";
            this.addEvaluationBtn.UseVisualStyleBackColor = false;
            this.addEvaluationBtn.Click += new System.EventHandler(this.addEvaluationBtn_Click);
            // 
            // EvaluationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "EvaluationControl";
            this.Size = new System.Drawing.Size(757, 557);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.gridHeader.ResumeLayout(false);
            this.gridHeader.PerformLayout();
            this.evaluationBodyPanel.ResumeLayout(false);
            this.evaluationDetailPanel.ResumeLayout(false);
            this.evaluationDetailPanel.PerformLayout();
            this.markSheetPanel.ResumeLayout(false);
            this.markSheetPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markSheet)).EndInit();
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Label breadcrumbLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel accentBar;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Panel gridHeader;
        private System.Windows.Forms.ComboBox selectEvaluationComboBox;
        private System.Windows.Forms.Label selectEvaluationLabel;
        private System.Windows.Forms.Label gridHeaderLabel;
        private System.Windows.Forms.TableLayoutPanel evaluationBodyPanel;
        private System.Windows.Forms.Panel evaluationDetailPanel;
        private System.Windows.Forms.Panel underline;
        private System.Windows.Forms.Label evaluationNameLabel;
        private System.Windows.Forms.Label weightageValueLabel;
        private System.Windows.Forms.Label weightageLabel;
        private System.Windows.Forms.Label totalMarksValueLabel;
        private System.Windows.Forms.Label totalMarksLabel;
        private System.Windows.Forms.TableLayoutPanel markSheetPanel;
        private System.Windows.Forms.DataGridView markSheet;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button addEvaluationBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn group;
        private System.Windows.Forms.DataGridViewTextBoxColumn project;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn obtainedMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn actions;
        private System.Windows.Forms.Button exportMarksBtn;
        private System.Windows.Forms.Button enterMarksBtn;
        private System.Windows.Forms.Label marksSheetHeader;
    }
}
