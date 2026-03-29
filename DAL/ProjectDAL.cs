using MidDb26_2025CS127.Models;
using MidDb26_2025CS127.Utilities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MidDb26_2025CS127.DAL
{
    internal class ProjectDAL
    {
        public static List<Project> GetAllProjects()
        {
            var projects = new Dictionary<int, Project>();
            var roleMap = GetAdvisorRoleMap();

            const string query = @"SELECT p.Id, p.Title, p.Description,
                                          gp.GroupId,
                                          CONCAT('Group ', gp.GroupId) AS GroupName,
                                          pa.AdvisorId,
                                          CONCAT(pr.FirstName, ' ', IFNULL(pr.LastName, '')) AS AdvisorName,
                                          pa.AdvisorRole
                                   FROM project AS p
                                   LEFT JOIN groupproject AS gp ON gp.ProjectId = p.Id
                                   LEFT JOIN projectadvisor AS pa ON pa.ProjectId = p.Id
                                   LEFT JOIN person AS pr ON pr.Id = pa.AdvisorId
                                   ORDER BY p.Title;";

            using (var reader = DatabaseHelper.GetData(query, new Dictionary<string, object>()))
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["Id"]);
                    Project project;
                    if (!projects.TryGetValue(id, out project))
                    {
                        project = new Project
                        {
                            Id = id,
                            Title = Convert.ToString(reader["Title"]),
                            Description = Convert.ToString(reader["Description"]),
                            AssignedGroupCount = reader["GroupId"] == DBNull.Value ? 0 : 1,
                            AssignedGroupName = Convert.ToString(reader["GroupName"]),
                            AdvisorName = string.Empty
                        };
                        projects[id] = project;
                    }

                    if (reader["AdvisorId"] != DBNull.Value)
                    {
                        int advisorId = Convert.ToInt32(reader["AdvisorId"]);
                        int roleId = reader["AdvisorRole"] == DBNull.Value ? 0 : Convert.ToInt32(reader["AdvisorRole"]);
                        string advisorName = Convert.ToString(reader["AdvisorName"]).Trim();

                        if (roleId == roleMap.MainRoleId) project.MainAdvisorId = advisorId;
                        else if (roleId == roleMap.CoRoleId) project.CoAdvisorId = advisorId;
                        else if (roleId == roleMap.IndustryRoleId) project.IndustryAdvisorId = advisorId;

                        if (!string.IsNullOrWhiteSpace(advisorName))
                        {
                            project.AdvisorName = string.IsNullOrWhiteSpace(project.AdvisorName)
                                ? advisorName
                                : project.AdvisorName + ", " + advisorName;
                        }
                    }
                }
            }

            return projects.Values.ToList();
        }

        public static List<Advisor> GetAdvisorOptions()
        {
            var advisors = new List<Advisor>();
            const string query = @"SELECT a.Id, p.FirstName, p.LastName
                                   FROM advisor AS a
                                   JOIN person AS p ON p.Id = a.Id
                                   ORDER BY p.FirstName, p.LastName;";

            using (var reader = DatabaseHelper.GetData(query, new Dictionary<string, object>()))
            {
                while (reader.Read())
                {
                    advisors.Add(new Advisor
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        FirstName = Convert.ToString(reader["FirstName"]),
                        LastName = Convert.ToString(reader["LastName"])
                    });
                }
            }
            return advisors;
        }

        public static int AddProject(Project project)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                const string query = @"INSERT INTO project (Title, Description)
                                       VALUES (@title, @description);";
                using (var cmd = DatabaseHelper.CreateCommand(connection, query, new Dictionary<string, object>
                {
                    { "@title", project.Title },
                    { "@description", string.IsNullOrWhiteSpace(project.Description) ? (object)DBNull.Value : project.Description }
                }))
                {
                    cmd.ExecuteNonQuery();
                    return (int)cmd.LastInsertedId;
                }
            }
        }

        public static bool UpdateProject(Project project)
        {
            const string query = @"UPDATE project SET Title = @title, Description = @description WHERE Id = @id;";
            return DatabaseHelper.Update(query, new Dictionary<string, object>
            {
                { "@id", project.Id },
                { "@title", project.Title },
                { "@description", string.IsNullOrWhiteSpace(project.Description) ? (object)DBNull.Value : project.Description }
            }) > 0;
        }

        public static void SaveProjectAdvisors(int projectId, Project project)
        {
            var roleMap = GetAdvisorRoleMap();

            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    using (var deleteCmd = DatabaseHelper.CreateCommand(connection, "DELETE FROM projectadvisor WHERE ProjectId = @projectId;", new Dictionary<string, object> { { "@projectId", projectId } }, transaction))
                    {
                        deleteCmd.ExecuteNonQuery();
                    }

                    InsertProjectAdvisor(connection, transaction, projectId, project.MainAdvisorId, roleMap.MainRoleId);
                    InsertProjectAdvisor(connection, transaction, projectId, project.CoAdvisorId, roleMap.CoRoleId);
                    InsertProjectAdvisor(connection, transaction, projectId, project.IndustryAdvisorId, roleMap.IndustryRoleId);

                    transaction.Commit();
                }
            }
        }

        private static void InsertProjectAdvisor(MySqlConnection connection, MySqlTransaction transaction, int projectId, int? advisorId, int roleId)
        {
            if (!advisorId.HasValue || advisorId.Value <= 0 || roleId <= 0) return;

            using (var insertCmd = DatabaseHelper.CreateCommand(connection,
                "INSERT INTO projectadvisor (AdvisorId, ProjectId, AdvisorRole, AssignmentDate) VALUES (@advisorId, @projectId, @roleId, @date);",
                new Dictionary<string, object>
                {
                    { "@advisorId", advisorId.Value },
                    { "@projectId", projectId },
                    { "@roleId", roleId },
                    { "@date", DateTime.Now }
                }, transaction))
            {
                insertCmd.ExecuteNonQuery();
            }
        }

        private class AdvisorRoleMap
        {
            public int MainRoleId { get; set; }
            public int CoRoleId { get; set; }
            public int IndustryRoleId { get; set; }
        }

        private static AdvisorRoleMap GetAdvisorRoleMap()
        {
            var map = new AdvisorRoleMap();
            const string query = @"SELECT Id, Value FROM lookup WHERE UPPER(Category) LIKE '%ADVISOR%ROLE%';";
            using (var reader = DatabaseHelper.GetData(query, new Dictionary<string, object>()))
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["Id"]);
                    string value = Convert.ToString(reader["Value"]).ToUpperInvariant();
                    if (value.Contains("MAIN")) map.MainRoleId = id;
                    else if (value.Contains("CO")) map.CoRoleId = id;
                    else if (value.Contains("INDUSTRY")) map.IndustryRoleId = id;
                }
            }

            if (map.MainRoleId == 0 || map.CoRoleId == 0 || map.IndustryRoleId == 0)
            {
                const string fallback = @"SELECT Id FROM lookup WHERE UPPER(Category) LIKE '%ADVISOR%ROLE%' ORDER BY Id;";
                var ids = new List<int>();
                using (var reader = DatabaseHelper.GetData(fallback, new Dictionary<string, object>()))
                {
                    while (reader.Read()) ids.Add(Convert.ToInt32(reader["Id"]));
                }
                if (ids.Count > 0 && map.MainRoleId == 0) map.MainRoleId = ids[0];
                if (ids.Count > 1 && map.CoRoleId == 0) map.CoRoleId = ids[1];
                if (ids.Count > 2 && map.IndustryRoleId == 0) map.IndustryRoleId = ids[2];
            }

            return map;
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
