using MidDb26_2025CS127.BL;
using MidDb26_2025CS127.Models;
using MidDb26_2025CS127.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MidDb26_2025CS127.UI.Froms
{
    public partial class AddEvaluationForm : Form
    {
        public event EventHandler evaluationSaved;

        private ComboBox evaluationTypeComboBox;
        private List<Lookup> evaluationTypes = new List<Lookup>();

        public AddEvaluationForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            BuildEvaluationTypeCombo();
            LoadEvaluationTypes();

            addBtn.Click += addBtn_Click;
            clearBtn.Click += clearBtn_Click;
        }

        private void BuildEvaluationTypeCombo()
        {
            evaluationTypeComboBox = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Popup,
                Location = evaluationNameTextBox.Location,
                Size = evaluationNameTextBox.Size
            };
            mainPanel.Controls.Add(evaluationTypeComboBox);
            evaluationNameTextBox.Visible = false;
        }

        private void LoadEvaluationTypes()
        {
            evaluationTypes = EvaluationBL.GetEvaluationTypes();
            evaluationTypeComboBox.Items.Clear();
            foreach (var item in evaluationTypes)
            {
                evaluationTypeComboBox.Items.Add(item.Value);
            }
            evaluationTypeComboBox.SelectedIndex = evaluationTypeComboBox.Items.Count > 0 ? 0 : -1;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            evaluationTypeComboBox.SelectedIndex = evaluationTypeComboBox.Items.Count > 0 ? 0 : -1;
            totalMarksTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int totalMarks;
            int weightage;

            if (!int.TryParse(totalMarksTextBox.Text.Trim(), out totalMarks))
            {
                MessageBox.Show("Enter valid total marks.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(lastNameTextBox.Text.Trim(), out weightage))
            {
                MessageBox.Show("Enter valid weightage.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string evalType = evaluationTypeComboBox.SelectedItem != null ? evaluationTypeComboBox.SelectedItem.ToString() : string.Empty;
            var evaluation = new Evaluation
            {
                Name = evalType,
                TotalMarks = totalMarks,
                TotalWeightage = weightage
            };

            string error;
            bool success = EvaluationBL.SaveEvaluation(evaluation, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!success)
            {
                MessageBox.Show("Unable to save evaluation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApplicationStatusService.PublishSuccess("Evaluation added successfully.");
            evaluationSaved?.Invoke(this, EventArgs.Empty);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void regLabel_Click(object sender, EventArgs e) { }
    }
}
