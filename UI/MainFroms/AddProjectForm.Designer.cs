namespace MidDb26_2025CS127.UI.Froms
{
    partial class AddProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProjectForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bottomLine = new System.Windows.Forms.Panel();
            this.leftLine = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.projectDescriptionLabel = new System.Windows.Forms.Label();
            this.regNoTextBox = new System.Windows.Forms.TextBox();
            this.projectTitleLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.bottomLine);
            this.mainPanel.Controls.Add(this.leftLine);
            this.mainPanel.Controls.Add(this.clearBtn);
            this.mainPanel.Controls.Add(this.addBtn);
            this.mainPanel.Controls.Add(this.firstNameTextBox);
            this.mainPanel.Controls.Add(this.projectDescriptionLabel);
            this.mainPanel.Controls.Add(this.regNoTextBox);
            this.mainPanel.Controls.Add(this.projectTitleLabel);
            this.mainPanel.Controls.Add(this.titleLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(582, 553);
            this.mainPanel.TabIndex = 0;
            // 
            // bottomLine
            // 
            this.bottomLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.bottomLine.Location = new System.Drawing.Point(-9, 499);
            this.bottomLine.Name = "bottomLine";
            this.bottomLine.Size = new System.Drawing.Size(600, 5);
            this.bottomLine.TabIndex = 55;
            // 
            // leftLine
            // 
            this.leftLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.leftLine.Location = new System.Drawing.Point(58, -15);
            this.leftLine.Name = "leftLine";
            this.leftLine.Size = new System.Drawing.Size(5, 900);
            this.leftLine.TabIndex = 54;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.White;
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.Location = new System.Drawing.Point(300, 198);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(72, 30);
            this.clearBtn.TabIndex = 52;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.addBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(189, 198);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(105, 30);
            this.addBtn.TabIndex = 51;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(168, 155);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(225, 24);
            this.firstNameTextBox.TabIndex = 41;
            // 
            // projectDescriptionLabel
            // 
            this.projectDescriptionLabel.AutoSize = true;
            this.projectDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectDescriptionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.projectDescriptionLabel.Location = new System.Drawing.Point(98, 129);
            this.projectDescriptionLabel.Name = "projectDescriptionLabel";
            this.projectDescriptionLabel.Size = new System.Drawing.Size(125, 23);
            this.projectDescriptionLabel.TabIndex = 40;
            this.projectDescriptionLabel.Text = "DESCRIPTION:";
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regNoTextBox.Location = new System.Drawing.Point(168, 102);
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.Size = new System.Drawing.Size(227, 24);
            this.regNoTextBox.TabIndex = 39;
            // 
            // projectTitleLabel
            // 
            this.projectTitleLabel.AutoSize = true;
            this.projectTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectTitleLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.projectTitleLabel.Location = new System.Drawing.Point(98, 76);
            this.projectTitleLabel.Name = "projectTitleLabel";
            this.projectTitleLabel.Size = new System.Drawing.Size(58, 23);
            this.projectTitleLabel.TabIndex = 38;
            this.projectTitleLabel.Text = "TITLE:";
            this.projectTitleLabel.Click += new System.EventHandler(this.regLabel_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.titleLabel.Location = new System.Drawing.Point(181, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(201, 45);
            this.titleLabel.TabIndex = 37;
            this.titleLabel.Text = "Add Project";
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "AddProjectForm";
            this.Text = "Add Project";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel bottomLine;
        private System.Windows.Forms.Panel leftLine;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label projectDescriptionLabel;
        private System.Windows.Forms.TextBox regNoTextBox;
        private System.Windows.Forms.Label projectTitleLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}