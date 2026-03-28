using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidDb26_2025CS127.Models
{
    internal class GroupEvaluation
    {
        public int GroupId { get; set; }
        public int EvaluationId { get; set; }
        public int ObtainedMarks { get; set; }
        public DateTime EvaluationDate { get; set; }

        public GroupEvaluation() { }

        public GroupEvaluation(int groupId, int evaluationId, int obtainedMarks, DateTime evaluationDate)
        {
            GroupId = groupId;
            EvaluationId = evaluationId;
            ObtainedMarks = obtainedMarks;
            EvaluationDate = evaluationDate;
        }
    }
}
