using System.Windows.Forms.VisualStyles;

namespace MidDb26_2025CS127.UI.UserControls
{
    partial class SidebarControl
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
            this.sidebarLayout = new System.Windows.Forms.TableLayoutPanel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.iconLabel = new System.Windows.Forms.Label();
            this.scrollPane = new System.Windows.Forms.Panel();
            this.reportNavBtn = new System.Windows.Forms.Button();
            this.evaluationNavBtn = new System.Windows.Forms.Button();
            this.academicLabel = new System.Windows.Forms.Label();
            this.groupNavBtn = new System.Windows.Forms.Button();
            this.projectNavBtn = new System.Windows.Forms.Button();
            this.advisoryNavBtn = new System.Windows.Forms.Button();
            this.studentNavBtn = new System.Windows.Forms.Button();
            this.managementLabel = new System.Windows.Forms.Label();
            this.dashboardNavBtn = new System.Windows.Forms.Button();
            this.overviewLabel = new System.Windows.Forms.Label();
            this.sidebarLayout.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.scrollPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarLayout
            // 
            this.sidebarLayout.ColumnCount = 1;
            this.sidebarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sidebarLayout.Controls.Add(this.logoPanel, 0, 0);
            this.sidebarLayout.Controls.Add(this.scrollPane, 0, 1);
            this.sidebarLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebarLayout.Location = new System.Drawing.Point(0, 0);
            this.sidebarLayout.Name = "sidebarLayout";
            this.sidebarLayout.RowCount = 2;
            this.sidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.sidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.sidebarLayout.Size = new System.Drawing.Size(260, 860);
            this.sidebarLayout.TabIndex = 0;
            // 
            // logoPanel
            // 
            this.logoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPanel.Controls.Add(this.titleLabel);
            this.logoPanel.Controls.Add(this.iconLabel);
            this.logoPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPanel.Location = new System.Drawing.Point(3, 3);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.logoPanel.Size = new System.Drawing.Size(254, 84);
            this.logoPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(68, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(150, 30);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "FYP Manager";
            // 
            // iconLabel
            // 
            this.iconLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.iconLabel.Location = new System.Drawing.Point(20, 22);
            this.iconLabel.Name = "iconLabel";
            this.iconLabel.Size = new System.Drawing.Size(44, 44);
            this.iconLabel.TabIndex = 0;
            this.iconLabel.Text = "⬡";
            this.iconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scrollPane
            // 
            this.scrollPane.AutoScroll = true;
            this.scrollPane.Controls.Add(this.reportNavBtn);
            this.scrollPane.Controls.Add(this.evaluationNavBtn);
            this.scrollPane.Controls.Add(this.academicLabel);
            this.scrollPane.Controls.Add(this.groupNavBtn);
            this.scrollPane.Controls.Add(this.projectNavBtn);
            this.scrollPane.Controls.Add(this.advisoryNavBtn);
            this.scrollPane.Controls.Add(this.studentNavBtn);
            this.scrollPane.Controls.Add(this.managementLabel);
            this.scrollPane.Controls.Add(this.dashboardNavBtn);
            this.scrollPane.Controls.Add(this.overviewLabel);
            this.scrollPane.Cursor = System.Windows.Forms.Cursors.Default;
            this.scrollPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPane.Location = new System.Drawing.Point(3, 93);
            this.scrollPane.Name = "scrollPane";
            this.scrollPane.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.scrollPane.Size = new System.Drawing.Size(254, 764);
            this.scrollPane.TabIndex = 1;
            // 
            // reportNavBtn
            // 
            this.reportNavBtn.FlatAppearance.BorderSize = 0;
            this.reportNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportNavBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportNavBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.reportNavBtn.Location = new System.Drawing.Point(0, 301);
            this.reportNavBtn.Name = "reportNavBtn";
            this.reportNavBtn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.reportNavBtn.Size = new System.Drawing.Size(232, 30);
            this.reportNavBtn.TabIndex = 9;
            this.reportNavBtn.Text = "Reports";
            this.reportNavBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportNavBtn.UseVisualStyleBackColor = false;
            this.reportNavBtn.Click += new System.EventHandler(this.reportNavBtn_Click);
            // 
            // evaluationNavBtn
            // 
            this.evaluationNavBtn.FlatAppearance.BorderSize = 0;
            this.evaluationNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.evaluationNavBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluationNavBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.evaluationNavBtn.Location = new System.Drawing.Point(-1, 265);
            this.evaluationNavBtn.Name = "evaluationNavBtn";
            this.evaluationNavBtn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.evaluationNavBtn.Size = new System.Drawing.Size(232, 30);
            this.evaluationNavBtn.TabIndex = 8;
            this.evaluationNavBtn.Text = "Evaluations";
            this.evaluationNavBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.evaluationNavBtn.UseVisualStyleBackColor = false;
            this.evaluationNavBtn.Click += new System.EventHandler(this.evaluationNavBtn_Click);
            // 
            // academicLabel
            // 
            this.academicLabel.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.academicLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.academicLabel.Location = new System.Drawing.Point(12, 238);
            this.academicLabel.Name = "academicLabel";
            this.academicLabel.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.academicLabel.Size = new System.Drawing.Size(220, 24);
            this.academicLabel.TabIndex = 7;
            this.academicLabel.Text = "ACADEMICS";
            this.academicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupNavBtn
            // 
            this.groupNavBtn.FlatAppearance.BorderSize = 0;
            this.groupNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupNavBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNavBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.groupNavBtn.Location = new System.Drawing.Point(-3, 204);
            this.groupNavBtn.Name = "groupNavBtn";
            this.groupNavBtn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.groupNavBtn.Size = new System.Drawing.Size(232, 30);
            this.groupNavBtn.TabIndex = 6;
            this.groupNavBtn.Text = "Group Management";
            this.groupNavBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.groupNavBtn.UseVisualStyleBackColor = false;
            this.groupNavBtn.Click += new System.EventHandler(this.groupNavBtn_Click);
            // 
            // projectNavBtn
            // 
            this.projectNavBtn.FlatAppearance.BorderSize = 0;
            this.projectNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectNavBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNavBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.projectNavBtn.Location = new System.Drawing.Point(-3, 168);
            this.projectNavBtn.Name = "projectNavBtn";
            this.projectNavBtn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.projectNavBtn.Size = new System.Drawing.Size(232, 30);
            this.projectNavBtn.TabIndex = 5;
            this.projectNavBtn.Text = "Project Management";
            this.projectNavBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.projectNavBtn.UseVisualStyleBackColor = false;
            this.projectNavBtn.Click += new System.EventHandler(this.projectNavBtn_Click);
            // 
            // advisoryNavBtn
            // 
            this.advisoryNavBtn.FlatAppearance.BorderSize = 0;
            this.advisoryNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advisoryNavBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advisoryNavBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.advisoryNavBtn.Location = new System.Drawing.Point(-3, 132);
            this.advisoryNavBtn.Name = "advisoryNavBtn";
            this.advisoryNavBtn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.advisoryNavBtn.Size = new System.Drawing.Size(232, 30);
            this.advisoryNavBtn.TabIndex = 4;
            this.advisoryNavBtn.Text = "Advisory Management";
            this.advisoryNavBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.advisoryNavBtn.UseVisualStyleBackColor = false;
            this.advisoryNavBtn.Click += new System.EventHandler(this.advisoryNavBtn_Click);
            // 
            // studentNavBtn
            // 
            this.studentNavBtn.FlatAppearance.BorderSize = 0;
            this.studentNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentNavBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNavBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.studentNavBtn.Location = new System.Drawing.Point(-3, 96);
            this.studentNavBtn.Name = "studentNavBtn";
            this.studentNavBtn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.studentNavBtn.Size = new System.Drawing.Size(232, 30);
            this.studentNavBtn.TabIndex = 3;
            this.studentNavBtn.Text = "Student Management";
            this.studentNavBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentNavBtn.UseVisualStyleBackColor = false;
            this.studentNavBtn.Click += new System.EventHandler(this.studentNavBtn_Click);
            // 
            // managementLabel
            // 
            this.managementLabel.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.managementLabel.Location = new System.Drawing.Point(10, 69);
            this.managementLabel.Name = "managementLabel";
            this.managementLabel.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.managementLabel.Size = new System.Drawing.Size(220, 24);
            this.managementLabel.TabIndex = 2;
            this.managementLabel.Text = "MANAGEMENT";
            this.managementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dashboardNavBtn
            // 
            this.dashboardNavBtn.FlatAppearance.BorderSize = 0;
            this.dashboardNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardNavBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardNavBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.dashboardNavBtn.Location = new System.Drawing.Point(0, 36);
            this.dashboardNavBtn.Name = "dashboardNavBtn";
            this.dashboardNavBtn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.dashboardNavBtn.Size = new System.Drawing.Size(232, 30);
            this.dashboardNavBtn.TabIndex = 1;
            this.dashboardNavBtn.Text = "Dashboard";
            this.dashboardNavBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardNavBtn.UseVisualStyleBackColor = false;
            this.dashboardNavBtn.Click += new System.EventHandler(this.dashboardNavBtn_Click);
            // 
            // overviewLabel
            // 
            this.overviewLabel.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.overviewLabel.Location = new System.Drawing.Point(10, 10);
            this.overviewLabel.Name = "overviewLabel";
            this.overviewLabel.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.overviewLabel.Size = new System.Drawing.Size(220, 24);
            this.overviewLabel.TabIndex = 0;
            this.overviewLabel.Text = "OVERVIEW";
            this.overviewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SidebarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(16)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.sidebarLayout);
            this.Name = "SidebarControl";
            this.Size = new System.Drawing.Size(260, 860);
            this.sidebarLayout.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.scrollPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private void Setup()
        {
            this.dashboardNavBtn.PerformClick();
        }

        private System.Windows.Forms.TableLayoutPanel sidebarLayout;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label iconLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel scrollPane;
        private System.Windows.Forms.Label overviewLabel;
        private System.Windows.Forms.Button dashboardNavBtn;
        private System.Windows.Forms.Button studentNavBtn;
        private System.Windows.Forms.Label managementLabel;
        private System.Windows.Forms.Button groupNavBtn;
        private System.Windows.Forms.Button projectNavBtn;
        private System.Windows.Forms.Button advisoryNavBtn;
        private System.Windows.Forms.Label academicLabel;
        private System.Windows.Forms.Button reportNavBtn;
        private System.Windows.Forms.Button evaluationNavBtn;
    }
}
