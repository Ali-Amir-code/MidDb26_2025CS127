namespace MidDb26_2025CS127.UI.UtilityForms
{
    partial class DatabaseCredForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseCredForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bottomLine = new System.Windows.Forms.Panel();
            this.leftLine = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            this.dbPasswordTextBox = new System.Windows.Forms.TextBox();
            this.dbPasswordLabel = new System.Windows.Forms.Label();
            this.dbUserTextBox = new System.Windows.Forms.TextBox();
            this.dbUserLabel = new System.Windows.Forms.Label();
            this.dbNameTextBox = new System.Windows.Forms.TextBox();
            this.dbNameLabel = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.serverAddressTextBox = new System.Windows.Forms.TextBox();
            this.serverAddressLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.bottomLine);
            this.mainPanel.Controls.Add(this.leftLine);
            this.mainPanel.Controls.Add(this.cancelBtn);
            this.mainPanel.Controls.Add(this.connectBtn);
            this.mainPanel.Controls.Add(this.dbPasswordTextBox);
            this.mainPanel.Controls.Add(this.dbPasswordLabel);
            this.mainPanel.Controls.Add(this.dbUserTextBox);
            this.mainPanel.Controls.Add(this.dbUserLabel);
            this.mainPanel.Controls.Add(this.dbNameTextBox);
            this.mainPanel.Controls.Add(this.dbNameLabel);
            this.mainPanel.Controls.Add(this.portTextBox);
            this.mainPanel.Controls.Add(this.portLabel);
            this.mainPanel.Controls.Add(this.serverAddressTextBox);
            this.mainPanel.Controls.Add(this.serverAddressLabel);
            this.mainPanel.Controls.Add(this.titleLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(582, 553);
            this.mainPanel.TabIndex = 1;
            // 
            // bottomLine
            // 
            this.bottomLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.bottomLine.Location = new System.Drawing.Point(3, 514);
            this.bottomLine.Name = "bottomLine";
            this.bottomLine.Size = new System.Drawing.Size(600, 5);
            this.bottomLine.TabIndex = 36;
            // 
            // leftLine
            // 
            this.leftLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.leftLine.Location = new System.Drawing.Point(70, 0);
            this.leftLine.Name = "leftLine";
            this.leftLine.Size = new System.Drawing.Size(5, 900);
            this.leftLine.TabIndex = 35;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(312, 366);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(72, 30);
            this.cancelBtn.TabIndex = 33;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.connectBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.ForeColor = System.Drawing.Color.White;
            this.connectBtn.Location = new System.Drawing.Point(201, 366);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(105, 30);
            this.connectBtn.TabIndex = 32;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // dbPasswordTextBox
            // 
            this.dbPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbPasswordTextBox.Location = new System.Drawing.Point(180, 331);
            this.dbPasswordTextBox.Name = "dbPasswordTextBox";
            this.dbPasswordTextBox.Size = new System.Drawing.Size(225, 24);
            this.dbPasswordTextBox.TabIndex = 28;
            this.dbPasswordTextBox.Tag = "";
            // 
            // dbPasswordLabel
            // 
            this.dbPasswordLabel.AutoSize = true;
            this.dbPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbPasswordLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dbPasswordLabel.Location = new System.Drawing.Point(110, 304);
            this.dbPasswordLabel.Name = "dbPasswordLabel";
            this.dbPasswordLabel.Size = new System.Drawing.Size(202, 23);
            this.dbPasswordLabel.TabIndex = 27;
            this.dbPasswordLabel.Text = "DATABASE PASSWORD:";
            // 
            // dbUserTextBox
            // 
            this.dbUserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbUserTextBox.Location = new System.Drawing.Point(180, 277);
            this.dbUserTextBox.Name = "dbUserTextBox";
            this.dbUserTextBox.Size = new System.Drawing.Size(225, 24);
            this.dbUserTextBox.TabIndex = 26;
            this.dbUserTextBox.Tag = "";
            // 
            // dbUserLabel
            // 
            this.dbUserLabel.AutoSize = true;
            this.dbUserLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbUserLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dbUserLabel.Location = new System.Drawing.Point(110, 247);
            this.dbUserLabel.Name = "dbUserLabel";
            this.dbUserLabel.Size = new System.Drawing.Size(149, 23);
            this.dbUserLabel.TabIndex = 25;
            this.dbUserLabel.Text = "DATABASE USER:";
            // 
            // dbNameTextBox
            // 
            this.dbNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbNameTextBox.Location = new System.Drawing.Point(180, 218);
            this.dbNameTextBox.Name = "dbNameTextBox";
            this.dbNameTextBox.Size = new System.Drawing.Size(225, 24);
            this.dbNameTextBox.TabIndex = 24;
            this.dbNameTextBox.Tag = "";
            this.dbNameTextBox.Text = "projectadb";
            // 
            // dbNameLabel
            // 
            this.dbNameLabel.AutoSize = true;
            this.dbNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dbNameLabel.Location = new System.Drawing.Point(110, 190);
            this.dbNameLabel.Name = "dbNameLabel";
            this.dbNameLabel.Size = new System.Drawing.Size(157, 23);
            this.dbNameLabel.TabIndex = 23;
            this.dbNameLabel.Text = "DATABASE NAME:";
            // 
            // portTextBox
            // 
            this.portTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portTextBox.Location = new System.Drawing.Point(180, 161);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(225, 24);
            this.portTextBox.TabIndex = 22;
            this.portTextBox.Text = "3306";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.portLabel.Location = new System.Drawing.Point(110, 133);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(59, 23);
            this.portLabel.TabIndex = 21;
            this.portLabel.Text = "PORT:";
            // 
            // serverAddressTextBox
            // 
            this.serverAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverAddressTextBox.Location = new System.Drawing.Point(180, 104);
            this.serverAddressTextBox.Name = "serverAddressTextBox";
            this.serverAddressTextBox.Size = new System.Drawing.Size(227, 24);
            this.serverAddressTextBox.TabIndex = 20;
            // 
            // serverAddressLabel
            // 
            this.serverAddressLabel.AutoSize = true;
            this.serverAddressLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverAddressLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.serverAddressLabel.Location = new System.Drawing.Point(110, 76);
            this.serverAddressLabel.Name = "serverAddressLabel";
            this.serverAddressLabel.Size = new System.Drawing.Size(159, 23);
            this.serverAddressLabel.TabIndex = 19;
            this.serverAddressLabel.Text = "SERVER ADDRESS:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.titleLabel.Location = new System.Drawing.Point(149, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(301, 45);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Connect Database";
            // 
            // DatabaseCredForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "DatabaseCredForm";
            this.Text = "Database Credentials";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel bottomLine;
        private System.Windows.Forms.Panel leftLine;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TextBox dbPasswordTextBox;
        private System.Windows.Forms.Label dbPasswordLabel;
        private System.Windows.Forms.TextBox dbUserTextBox;
        private System.Windows.Forms.Label dbUserLabel;
        private System.Windows.Forms.TextBox dbNameTextBox;
        private System.Windows.Forms.Label dbNameLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox serverAddressTextBox;
        private System.Windows.Forms.Label serverAddressLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}