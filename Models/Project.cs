using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidDb26_2025CS127.Models
{
    internal class Project
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int AssignedGroupCount { get; set; }

        public Project() { }

        public Project(string title, string description = null)
        {
            Title = title;
            Description = description;
        }
    }
}
