using MidDb26_2025CS127.DAL;
using MidDb26_2025CS127.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MidDb26_2025CS127.BL
{
    internal class GroupBL
    {
        public static List<Group> GetAllGroups()
        {
            return GroupDAL.GetAllGroups();
        }

        public static List<Project> GetProjectsForAssignment()
        {
            return GroupDAL.GetProjectsForAssignment();
        }

        public static List<Student> GetUnassignedStudents()
        {
            return GroupDAL.GetUnassignedStudents();
        }

        public static bool SaveGroup(Group group, out string errorMessage)
        {
            errorMessage = ValidateGroup(group);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                return false;
            }

            return GroupDAL.AddGroup(group);
        }

        public static bool DeleteGroup(int groupId)
        {
            return GroupDAL.DeleteGroup(groupId);
        }

        public static void DeleteGroups(IEnumerable<int> groupIds)
        {
            if (groupIds == null) return;

            foreach (var groupId in groupIds)
            {
                GroupDAL.DeleteGroup(groupId);
            }
        }

        public static List<Group> SortGroups(IEnumerable<Group> groups, string sortKey)
        {
            var query = (groups ?? Enumerable.Empty<Group>()).AsEnumerable();
            if (string.Equals(sortKey, "Date", StringComparison.OrdinalIgnoreCase))
            {
                return query.OrderBy(g => g.Created_On).ToList();
            }

            return query.OrderBy(g => g.Id).ToList();
        }

        private static string ValidateGroup(Group group)
        {
            if (!group.ProjectId.HasValue || group.ProjectId.Value <= 0)
            {
                return "Please select a project.";
            }

            if (group.Members == null || group.Members.Count == 0)
            {
                return "Please select at least one student.";
            }

            return string.Empty;
        }
    }
}
