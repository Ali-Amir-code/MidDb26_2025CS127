using MidDb26_2025CS127.BL;
using MidDb26_2025CS127.Models;
using MidDb26_2025CS127.Utilities;
using System;
using System.Windows.Forms;

namespace MidDb26_2025CS127.UI.Froms
{
    public partial class AddEvaluationForm : Form
    {
        public event EventHandler evaluationSaved;

        public AddEvaluationForm()
        {
            InitializeComponent();
            addBtn.Click += addBtn_Click;
            clearBtn.Click += clearBtn_Click;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            evaluationNameTextBox.Text = string.Empty;
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

            var evaluation = new Evaluation
            {
                Name = evaluationNameTextBox.Text.Trim(),
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
