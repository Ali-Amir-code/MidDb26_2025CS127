using MidDb26_2025CS127.DAL;
using MidDb26_2025CS127.Models;
using MidDb26_2025CS127.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MidDb26_2025CS127.BL
{
    internal class ProjectBL
    {
        public static List<Project> GetAllProjects() => ProjectDAL.GetAllProjects();

        public static List<Advisor> GetAdvisorOptions() => ProjectDAL.GetAdvisorOptions();

        public static bool SaveProject(Project project, bool isUpdate, out string errorMessage)
        {
            errorMessage = GetErrorMessage(project);
            if (!string.IsNullOrEmpty(errorMessage)) return false;

            NormalizeProject(project);

            int projectId;
            if (isUpdate)
            {
                bool updated = ProjectDAL.UpdateProject(project);
                if (!updated)
                {
                    errorMessage = "Unable to save project.";
                    return false;
                }
                projectId = project.Id;
            }
            else
            {
                projectId = ProjectDAL.AddProject(project);
            }

            ProjectDAL.SaveProjectAdvisors(projectId, project);
            return true;
        }

        public static bool DeleteProject(int projectId) => ProjectDAL.DeleteProject(projectId);

        public static void DeleteProjects(IEnumerable<int> projectIds)
        {
            if (projectIds == null) return;
            foreach (var id in projectIds) ProjectDAL.DeleteProject(id);
        }

        public static List<Project> FilterProjects(IEnumerable<Project> source, string title, string description, string advisorName)
        {
            var query = (source ?? Enumerable.Empty<Project>()).AsEnumerable();
            if (!string.IsNullOrWhiteSpace(title)) query = query.Where(p => !string.IsNullOrWhiteSpace(p.Title) && p.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0);
            if (!string.IsNullOrWhiteSpace(description)) query = query.Where(p => !string.IsNullOrWhiteSpace(p.Description) && p.Description.IndexOf(description, StringComparison.OrdinalIgnoreCase) >= 0);
            if (!string.IsNullOrWhiteSpace(advisorName) && !advisorName.Equals("All", StringComparison.OrdinalIgnoreCase)) query = query.Where(p => !string.IsNullOrWhiteSpace(p.AdvisorName) && p.AdvisorName.IndexOf(advisorName, StringComparison.OrdinalIgnoreCase) >= 0);
            return query.ToList();
        }

        public static string GetErrorMessage(Project project)
        {
            if (string.IsNullOrWhiteSpace(project.Title)) return "Missing project title. Title is required.";
            return string.Empty;
        }

        private static void NormalizeProject(Project project)
        {
            project.Title = ValidationUtility.NormalizeRequired(project.Title);
            project.Description = ValidationUtility.NormalizeOptional(project.Description);
        }
    }
}
