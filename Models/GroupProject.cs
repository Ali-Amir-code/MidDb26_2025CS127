using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidDb26_2025CS127.Models
{
    internal class GroupProject
    {
        public int ProjectId { get; set; }
        public int GroupId { get; set; }
        public DateTime AssignmentDate { get; set; }

        public GroupProject() { }

        public GroupProject(int projectId, int groupId, DateTime assignmentDate)
        {
            ProjectId = projectId;
            GroupId = groupId;
            AssignmentDate = assignmentDate;
        }
    }
}
