using System;
using System.Collections.Generic;

namespace MidDb26_2025CS127.Models
{
    public class Group
    {
        public int Id { get; set; }
        public DateTime Created_On { get; set; }

        public int? ProjectId { get; set; }
        public string ProjectTitle { get; set; }
        public List<Student> Members { get; set; } = new List<Student>();

        public string DisplayName
        {
            get { return $"Group {Id}"; }
        }

        public Group() { }

        public Group(DateTime createdOn)
        {
            Created_On = createdOn;
        }
    }
}
