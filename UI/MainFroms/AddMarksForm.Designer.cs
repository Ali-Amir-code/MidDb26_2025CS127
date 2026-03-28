namespace MidDb26_2025CS127.UI.Froms
{
    partial class AddMarksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMarksForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bottomLine = new System.Windows.Forms.Panel();
            this.leftLine = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.evaluationDateLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.marksLabel = new System.Windows.Forms.Label();
            this.chooseEvaluationLabel = new System.Windows.Forms.Label();
            this.chooseGroupLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.evaluationComboBox = new System.Windows.Forms.ComboBox();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.evaluationComboBox);
            this.mainPanel.Controls.Add(this.groupComboBox);
            this.mainPanel.Controls.Add(this.bottomLine);
            this.mainPanel.Controls.Add(this.leftLine);
            this.mainPanel.Controls.Add(this.dateTimePicker1);
            this.mainPanel.Controls.Add(this.clearBtn);
            this.mainPanel.Controls.Add(this.addBtn);
            this.mainPanel.Controls.Add(this.evaluationDateLabel);
            this.mainPanel.Controls.Add(this.lastNameTextBox);
            this.mainPanel.Controls.Add(this.marksLabel);
            this.mainPanel.Controls.Add(this.chooseEvaluationLabel);
            this.mainPanel.Controls.Add(this.chooseGroupLabel);
            this.mainPanel.Controls.Add(this.titleLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(582, 553);
            this.mainPanel.TabIndex = 1;
            // 
            // bottomLine
            // 
            this.bottomLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.bottomLine.Location = new System.Drawing.Point(3, 514);
            this.bottomLine.Name = "bottomLine";
            this.bottomLine.Size = new System.Drawing.Size(600, 5);
            this.bottomLine.TabIndex = 36;
            // 
            // leftLine
            // 
            this.leftLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.leftLine.Location = new System.Drawing.Point(70, 0);
            this.leftLine.Name = "leftLine";
            this.leftLine.Size = new System.Drawing.Size(5, 900);
            this.leftLine.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 269);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 24);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.White;
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.Location = new System.Drawing.Point(312, 323);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(72, 30);
            this.clearBtn.TabIndex = 33;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.addBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(201, 323);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(105, 30);
            this.addBtn.TabIndex = 32;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // evaluationDateLabel
            // 
            this.evaluationDateLabel.AutoSize = true;
            this.evaluationDateLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluationDateLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.evaluationDateLabel.Location = new System.Drawing.Point(110, 243);
            this.evaluationDateLabel.Name = "evaluationDateLabel";
            this.evaluationDateLabel.Size = new System.Drawing.Size(167, 23);
            this.evaluationDateLabel.TabIndex = 25;
            this.evaluationDateLabel.Text = "EVALUATION DATE:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(180, 216);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(225, 24);
            this.lastNameTextBox.TabIndex = 24;
            this.lastNameTextBox.Tag = "";
            // 
            // marksLabel
            // 
            this.marksLabel.AutoSize = true;
            this.marksLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marksLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.marksLabel.Location = new System.Drawing.Point(110, 190);
            this.marksLabel.Name = "marksLabel";
            this.marksLabel.Size = new System.Drawing.Size(132, 23);
            this.marksLabel.TabIndex = 23;
            this.marksLabel.Text = "ENTER MARKS:";
            // 
            // chooseEvaluationLabel
            // 
            this.chooseEvaluationLabel.AutoSize = true;
            this.chooseEvaluationLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseEvaluationLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chooseEvaluationLabel.Location = new System.Drawing.Point(110, 137);
            this.chooseEvaluationLabel.Name = "chooseEvaluationLabel";
            this.chooseEvaluationLabel.Size = new System.Drawing.Size(193, 23);
            this.chooseEvaluationLabel.TabIndex = 21;
            this.chooseEvaluationLabel.Text = "CHOOSE EVALUATION:";
            // 
            // chooseGroupLabel
            // 
            this.chooseGroupLabel.AutoSize = true;
            this.chooseGroupLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseGroupLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chooseGroupLabel.Location = new System.Drawing.Point(110, 84);
            this.chooseGroupLabel.Name = "chooseGroupLabel";
            this.chooseGroupLabel.Size = new System.Drawing.Size(147, 23);
            this.chooseGroupLabel.TabIndex = 19;
            this.chooseGroupLabel.Text = "CHOOSE GROUP:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.titleLabel.Location = new System.Drawing.Point(193, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(207, 45);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Enter Marks";
            // 
            // groupComboBox
            // 
            this.groupComboBox.BackColor = System.Drawing.Color.White;
            this.groupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.groupComboBox.Location = new System.Drawing.Point(180, 110);
            this.groupComboBox.MaxDropDownItems = 12;
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(225, 26);
            this.groupComboBox.TabIndex = 37;
            // 
            // evaluationComboBox
            // 
            this.evaluationComboBox.BackColor = System.Drawing.Color.White;
            this.evaluationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.evaluationComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.evaluationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluationComboBox.FormattingEnabled = true;
            this.evaluationComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.evaluationComboBox.Location = new System.Drawing.Point(180, 163);
            this.evaluationComboBox.MaxDropDownItems = 12;
            this.evaluationComboBox.Name = "evaluationComboBox";
            this.evaluationComboBox.Size = new System.Drawing.Size(225, 26);
            this.evaluationComboBox.TabIndex = 38;
            // 
            // AddMarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "AddMarksForm";
            this.Text = "Add Marks";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel bottomLine;
        private System.Windows.Forms.Panel leftLine;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label evaluationDateLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label marksLabel;
        private System.Windows.Forms.Label chooseEvaluationLabel;
        private System.Windows.Forms.Label chooseGroupLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.ComboBox evaluationComboBox;
    }
}