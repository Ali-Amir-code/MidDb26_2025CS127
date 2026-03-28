using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidDb26_2025CS127.Models
{
    internal class GroupStudent
    {
        public int GroupId { get; set; }
        public int StudentId { get; set; }
        public int Status { get; set; }          
        public DateTime AssignmentDate { get; set; }

        public GroupStudent() { }

        public GroupStudent(int groupId, int studentId, int status, DateTime assignmentDate)
        {
            GroupId = groupId;
            StudentId = studentId;
            Status = status;
            AssignmentDate = assignmentDate;
        }
    }
}
