using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidDb26_2025CS127.Models
{
    internal class Advisor : Person
    {
        public int AdvisorId { get; set; }
        public int Designation { get; set; }     
        public decimal? Salary { get; set; }
    }
}
