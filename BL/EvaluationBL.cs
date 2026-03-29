using MidDb26_2025CS127.DAL;
using MidDb26_2025CS127.Models;
using System.Collections.Generic;

namespace MidDb26_2025CS127.BL
{
    internal class EvaluationBL
    {
        public static List<Evaluation> GetAllEvaluations() => EvaluationDAL.GetAllEvaluations();
        public static List<EvaluationMarkRow> GetEvaluationMarkRows(int evaluationId) => EvaluationDAL.GetEvaluationMarkRows(evaluationId);

        public static bool SaveEvaluation(Evaluation evaluation, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrWhiteSpace(evaluation.Name))
            {
                error = "Please enter an evaluation name.";
                return false;
            }
            if (evaluation.TotalMarks <= 0)
            {
                error = "Total marks must be greater than zero.";
                return false;
            }
            if (evaluation.TotalWeightage <= 0)
            {
                error = "Weightage must be greater than zero.";
                return false;
            }
            return EvaluationDAL.AddEvaluation(evaluation);
        }
    }
}
