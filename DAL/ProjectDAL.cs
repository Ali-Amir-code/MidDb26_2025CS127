using MidDb26_2025CS127.Models;
using MidDb26_2025CS127.Utilities;
using MySql.Data.MySqlClient;
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
                    projects.Add(new Project
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Title = Convert.ToString(reader["Title"]),
                        Description = Convert.ToString(reader["Description"]),
                        AssignedGroupCount = reader["GroupId"] == DBNull.Value ? 0 : 1,
                        AssignedGroupName = Convert.ToString(reader["GroupName"]),
                        AdvisorId = reader["AdvisorId"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["AdvisorId"]),
                        AdvisorName = Convert.ToString(reader["AdvisorName"]).Trim(),
                        AdvisorRoleId = reader["AdvisorRole"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["AdvisorRole"])
                    });
                }
            }

            return projects;
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

        public static List<Lookup> GetAdvisorRoleOptions()
        {
            var roles = new List<Lookup>();
            const string query = @"SELECT Id, Value, Category
                                   FROM lookup
                                   WHERE UPPER(Category) LIKE '%ADVISOR%ROLE%'
                                   ORDER BY Value;";

            using (var reader = DatabaseHelper.GetData(query, new Dictionary<string, object>()))
            {
                while (reader.Read())
                {
                    roles.Add(new Lookup
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Value = Convert.ToString(reader["Value"]),
                        Category = Convert.ToString(reader["Category"])
                    });
                }
            }

            return roles;
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

        public static void SaveProjectAdvisor(int projectId, int? advisorId, int? roleId)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    using (var deleteCmd = DatabaseHelper.CreateCommand(connection, "DELETE FROM projectadvisor WHERE ProjectId = @projectId;", new Dictionary<string, object> { { "@projectId", projectId } }, transaction))
                    {
                        deleteCmd.ExecuteNonQuery();
                    }

                    if (advisorId.HasValue && advisorId.Value > 0)
                    {
                        int resolvedRoleId = roleId.HasValue && roleId.Value > 0 ? roleId.Value : GetDefaultAdvisorRoleId(connection, transaction);
                        using (var insertCmd = DatabaseHelper.CreateCommand(connection,
                            "INSERT INTO projectadvisor (AdvisorId, ProjectId, AdvisorRole, AssignmentDate) VALUES (@advisorId, @projectId, @roleId, @date);",
                            new Dictionary<string, object>
                            {
                                { "@advisorId", advisorId.Value },
                                { "@projectId", projectId },
                                { "@roleId", resolvedRoleId },
                                { "@date", DateTime.Now }
                            }, transaction))
                        {
                            insertCmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }
            }
        }

        private static int GetDefaultAdvisorRoleId(MySqlConnection connection, MySqlTransaction transaction)
        {
            const string query = @"SELECT Id FROM lookup WHERE UPPER(Category) LIKE '%ADVISOR%ROLE%' ORDER BY Id LIMIT 1;";
            using (var cmd = DatabaseHelper.CreateCommand(connection, query, new Dictionary<string, object>(), transaction))
            {
                object value = cmd.ExecuteScalar();
                if (value != null && value != DBNull.Value) return Convert.ToInt32(value);
            }
            return 11;
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
