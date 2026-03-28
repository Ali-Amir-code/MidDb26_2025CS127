using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidDb26_2025CS127.Models
{
    internal class Lookup
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Category { get; set; }

        public Lookup() { }

        public Lookup(int id, string value, string category)
        {
            Id = id;
            Value = value;
            Category = category;
        }
    }
}
