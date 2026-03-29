using MidDb26_2025CS127.BL;
using MidDb26_2025CS127.Models;
using MidDb26_2025CS127.UI.Froms;
using MidDb26_2025CS127.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MidDb26_2025CS127.UI.UserControls
{
    public partial class EvaluationControl : UserControl
    {
        private List<Evaluation> evaluations = new List<Evaluation>();

        public EvaluationControl()
        {
            InitializeComponent();
            LoadEvaluationData();
        }

        private void LoadEvaluationData()
        {
            evaluations = EvaluationBL.GetAllEvaluations();
            selectEvaluationComboBox.Items.Clear();
            foreach (var evaluation in evaluations)
            {
                selectEvaluationComboBox.Items.Add($"{evaluation.Id} - {evaluation.Name}");
            }

            if (selectEvaluationComboBox.Items.Count > 0)
            {
                selectEvaluationComboBox.SelectedIndex = 0;
            }
            else
            {
                markSheet.Rows.Clear();
                evaluationNameLabel.Text = "No Evaluation";
                totalMarksValueLabel.Text = "0";
                weightageValueLabel.Text = "0%";
                marksSheetHeader.Text = "Marks Sheet";
            }
        }

        private Evaluation GetSelectedEvaluation()
        {
            if (selectEvaluationComboBox.SelectedIndex < 0 || selectEvaluationComboBox.SelectedIndex >= evaluations.Count)
            {
                return null;
            }
            return evaluations[selectEvaluationComboBox.SelectedIndex];
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEvaluation = GetSelectedEvaluation();
            if (selectedEvaluation == null)
            {
                return;
            }

            evaluationNameLabel.Text = selectedEvaluation.Name;
            totalMarksValueLabel.Text = selectedEvaluation.TotalMarks.ToString();
            weightageValueLabel.Text = selectedEvaluation.TotalWeightage + "%";
            marksSheetHeader.Text = "Marks Sheet -- " + selectedEvaluation.Name;

            markSheet.Rows.Clear();
            foreach (var row in EvaluationBL.GetEvaluationMarkRows(selectedEvaluation.Id))
            {
                markSheet.Rows.Add($"Group {row.GroupId}", string.IsNullOrWhiteSpace(row.ProjectTitle) ? "Not assigned" : row.ProjectTitle, row.EvaluationDate.ToShortDateString(), row.ObtainedMarks, string.Empty);
            }
        }

        private void addEvaluationBtn_Click(object sender, EventArgs e)
        {
            using (var form = new AddEvaluationForm())
            {
                form.evaluationSaved += Form_evaluationSaved;
                form.ShowDialog();
            }
        }

        private void Form_evaluationSaved(object sender, EventArgs e)
        {
            LoadEvaluationData();
            ApplicationStatusService.PublishSuccess("Evaluation data refreshed.");
        }

        private void enterMarksBtn_Click(object sender, EventArgs e)
        {
            (new AddMarksForm()).ShowDialog();
            var selected = GetSelectedEvaluation();
            if (selected != null)
            {
                sortComboBox_SelectedIndexChanged(this, EventArgs.Empty);
            }
        }
    }
}
