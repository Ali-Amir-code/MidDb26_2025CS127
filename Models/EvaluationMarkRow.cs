using System;

namespace MidDb26_2025CS127.Models
{
    internal class EvaluationMarkRow
    {
        public int GroupId { get; set; }
        public string ProjectTitle { get; set; }
        public DateTime EvaluationDate { get; set; }
        public int ObtainedMarks { get; set; }
    }
}
