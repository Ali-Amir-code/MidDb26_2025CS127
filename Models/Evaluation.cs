using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidDb26_2025CS127.Models
{
    internal class Evaluation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }
        public int TotalWeightage { get; set; }

        public Evaluation() { }

        public Evaluation(string name, int totalMarks, int totalWeightage)
        {
            Name = name;
            TotalMarks = totalMarks;
            TotalWeightage = totalWeightage;
        }
    }

}
