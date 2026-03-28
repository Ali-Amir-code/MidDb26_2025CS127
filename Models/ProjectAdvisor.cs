using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidDb26_2025CS127.Models
{
    internal class ProjectAdvisor
    {
        public int AdvisorId { get; set; }
        public int ProjectId { get; set; }
        public int AdvisorRole { get; set; }     
        public DateTime AssignmentDate { get; set; }

        public ProjectAdvisor() { }

        public ProjectAdvisor(int advisorId, int projectId, int advisorRole, DateTime assignmentDate)
        {
            AdvisorId = advisorId;
            ProjectId = projectId;
            AdvisorRole = advisorRole;
            AssignmentDate = assignmentDate;
        }
    }
}
