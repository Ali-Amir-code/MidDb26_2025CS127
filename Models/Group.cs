using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidDb26_2025CS127.Models
{
    internal class Group
    {
        public int Id { get; set; }
        public DateTime Created_On { get; set; }

        public Group() { }

        public Group(DateTime createdOn)
        {
            Created_On = createdOn;
        }
    }
}
