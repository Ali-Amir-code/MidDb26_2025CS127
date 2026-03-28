using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidDb26_2025CS127.Models
{
    public class Student : Person
    {
        public int StudentId { get; set; }
        public string RegistrationNo { get; set; }
    }
}
