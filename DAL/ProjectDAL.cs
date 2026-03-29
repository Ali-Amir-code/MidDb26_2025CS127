using MidDb26_2025CS127.Models;
using MidDb26_2025CS127.Utilities;
using System;
using System.Collections.Generic;

namespace MidDb26_2025CS127.DAL
{
    internal class ProjectDAL
    {
        public static List<Project> GetAllProjects()
        {
            var projects = new List<Project>();
            const string query = @"SELECT p.Id, p.Title, p.Description,
                                          gp.GroupId,
                                          CONCAT('Group ', gp.GroupId) AS GroupName
                                   FROM project AS p
                                   LEFT JOIN groupproject AS gp ON gp.ProjectId = p.Id
                                   ORDER BY p.Title;";

            using (var reader = DatabaseHelper.GetData(query, new Dictionary<string, object>()))
            {
                while (reader.Read())
                {
                    projects.Add(new Project
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Title = Convert.ToString(reader["Title"]),
                        Description = Convert.ToString(reader["Description"]),
                        AssignedGroupCount = reader["GroupId"] == DBNull.Value ? 0 : 1,
                        AssignedGroupName = Convert.ToString(reader["GroupName"])
                    });
                }
            }

            return projects;
        }

        public static bool AddProject(Project project)
        {
            const string query = @"INSERT INTO project (Title, Description)
                                   VALUES (@title, @description);";

            return DatabaseHelper.Update(query, new Dictionary<string, object>
            {
                { "@title", project.Title },
                { "@description", string.IsNullOrWhiteSpace(project.Description) ? (object)DBNull.Value : project.Description }
            }) > 0;
        }

        public static bool UpdateProject(Project project)
        {
            const string query = @"UPDATE project
                                   SET Title = @title,
                                       Description = @description
                                   WHERE Id = @id;";

            return DatabaseHelper.Update(query, new Dictionary<string, object>
            {
                { "@id", project.Id },
                { "@title", project.Title },
                { "@description", string.IsNullOrWhiteSpace(project.Description) ? (object)DBNull.Value : project.Description }
            }) > 0;
        }

        public static bool DeleteProject(int projectId)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (var groupProjectDelete = DatabaseHelper.CreateCommand(connection, "DELETE FROM groupproject WHERE ProjectId = @id;", new Dictionary<string, object> { { "@id", projectId } }, transaction))
                        {
                            groupProjectDelete.ExecuteNonQuery();
                        }

                        using (var projectAdvisorDelete = DatabaseHelper.CreateCommand(connection, "DELETE FROM projectadvisor WHERE ProjectId = @id;", new Dictionary<string, object> { { "@id", projectId } }, transaction))
                        {
                            projectAdvisorDelete.ExecuteNonQuery();
                        }

                        using (var projectDelete = DatabaseHelper.CreateCommand(connection, "DELETE FROM project WHERE Id = @id;", new Dictionary<string, object> { { "@id", projectId } }, transaction))
                        {
                            projectDelete.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
