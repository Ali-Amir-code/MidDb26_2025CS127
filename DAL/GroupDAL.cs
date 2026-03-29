using MidDb26_2025CS127.Models;
using MidDb26_2025CS127.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MidDb26_2025CS127.DAL
{
    internal class GroupDAL
    {
        public static List<Group> GetAllGroups()
        {
            var groupsById = new Dictionary<int, Group>();

            const string groupsQuery = @"SELECT g.Id, g.Created_On, p.Id AS ProjectId, p.Title AS ProjectTitle
                                         FROM `group` AS g
                                         LEFT JOIN groupproject AS gp ON gp.GroupId = g.Id
                                         LEFT JOIN project AS p ON p.Id = gp.ProjectId
                                         ORDER BY g.Id;";

            using (var reader = DatabaseHelper.GetData(groupsQuery, new Dictionary<string, object>()))
            {
                while (reader.Read())
                {
                    int groupId = Convert.ToInt32(reader["Id"]);
                    if (groupsById.ContainsKey(groupId))
                    {
                        continue;
                    }

                    groupsById[groupId] = new Group
                    {
                        Id = groupId,
                        Created_On = Convert.ToDateTime(reader["Created_On"]),
                        ProjectId = reader["ProjectId"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["ProjectId"]),
                        ProjectTitle = Convert.ToString(reader["ProjectTitle"]),
                        Members = new List<Student>()
                    };
                }
            }

            if (!groupsById.Any())
            {
                return new List<Group>();
            }

            const string membersQuery = @"SELECT gs.GroupId, s.Id AS StudentId, s.RegistrationNo, p.FirstName, p.LastName
                                          FROM groupstudent AS gs
                                          JOIN student AS s ON s.Id = gs.StudentId
                                          JOIN person AS p ON p.Id = s.Id
                                          ORDER BY gs.GroupId, s.RegistrationNo;";

            using (var reader = DatabaseHelper.GetData(membersQuery, new Dictionary<string, object>()))
            {
                while (reader.Read())
                {
                    int groupId = Convert.ToInt32(reader["GroupId"]);
                    if (!groupsById.ContainsKey(groupId))
                    {
                        continue;
                    }

                    groupsById[groupId].Members.Add(new Student
                    {
                        Id = Convert.ToInt32(reader["StudentId"]),
                        RegistrationNo = Convert.ToString(reader["RegistrationNo"]),
                        FirstName = Convert.ToString(reader["FirstName"]),
                        LastName = Convert.ToString(reader["LastName"])
                    });
                }
            }

            return groupsById.Values.ToList();
        }

        public static List<Project> GetProjectsForAssignment()
        {
            var projects = new List<Project>();
            const string query = "SELECT Id, Title FROM project ORDER BY Title;";

            using (var reader = DatabaseHelper.GetData(query, new Dictionary<string, object>()))
            {
                while (reader.Read())
                {
                    projects.Add(new Project
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Title = Convert.ToString(reader["Title"])
                    });
                }
            }

            return projects;
        }

        public static List<Student> GetUnassignedStudents()
        {
            var students = new List<Student>();
            const string query = @"SELECT s.Id, s.RegistrationNo, p.FirstName, p.LastName
                                   FROM student AS s
                                   JOIN person AS p ON p.Id = s.Id
                                   LEFT JOIN groupstudent AS gs ON gs.StudentId = s.Id
                                   WHERE gs.StudentId IS NULL
                                   ORDER BY s.RegistrationNo;";

            using (var reader = DatabaseHelper.GetData(query, new Dictionary<string, object>()))
            {
                while (reader.Read())
                {
                    students.Add(new Student
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        RegistrationNo = Convert.ToString(reader["RegistrationNo"]),
                        FirstName = Convert.ToString(reader["FirstName"]),
                        LastName = Convert.ToString(reader["LastName"])
                    });
                }
            }

            return students;
        }

        public static bool AddGroup(Group group)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        const string groupInsert = "INSERT INTO `group` (Created_On) VALUES (@createdOn);";
                        long groupId;

                        using (var groupCommand = DatabaseHelper.CreateCommand(connection, groupInsert, new Dictionary<string, object>
                        {
                            { "@createdOn", group.Created_On }
                        }, transaction))
                        {
                            groupCommand.ExecuteNonQuery();
                            groupId = groupCommand.LastInsertedId;
                        }

                        if (group.ProjectId.HasValue)
                        {
                            using (var projectCommand = DatabaseHelper.CreateCommand(connection,
                                "INSERT INTO groupproject (ProjectId, GroupId, AssignmentDate) VALUES (@projectId, @groupId, @date);",
                                new Dictionary<string, object>
                                {
                                    { "@projectId", group.ProjectId.Value },
                                    { "@groupId", groupId },
                                    { "@date", DateTime.Now }
                                }, transaction))
                            {
                                projectCommand.ExecuteNonQuery();
                            }
                        }

                        int activeStatus = GetActiveStudentStatusId(connection, transaction);

                        foreach (var student in group.Members)
                        {
                            using (var memberCommand = DatabaseHelper.CreateCommand(connection,
                                "INSERT INTO groupstudent (GroupId, StudentId, Status, AssignmentDate) VALUES (@groupId, @studentId, @status, @date);",
                                new Dictionary<string, object>
                                {
                                    { "@groupId", groupId },
                                    { "@studentId", student.Id },
                                    { "@status", activeStatus },
                                    { "@date", DateTime.Now }
                                }, transaction))
                            {
                                memberCommand.ExecuteNonQuery();
                            }
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

        public static bool DeleteGroup(int groupId)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        ExecuteDelete(connection, transaction, "DELETE FROM groupstudent WHERE GroupId = @groupId;", groupId);
                        ExecuteDelete(connection, transaction, "DELETE FROM groupproject WHERE GroupId = @groupId;", groupId);
                        ExecuteDelete(connection, transaction, "DELETE FROM groupevaluation WHERE GroupId = @groupId;", groupId);
                        ExecuteDelete(connection, transaction, "DELETE FROM `group` WHERE Id = @groupId;", groupId);

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


        private static int GetActiveStudentStatusId(MySql.Data.MySqlClient.MySqlConnection connection, MySql.Data.MySqlClient.MySqlTransaction transaction)
        {
            const string query = @"SELECT Id
                                   FROM lookup
                                   WHERE UPPER(Category) LIKE '%STATUS%'
                                     AND UPPER(Value) = 'ACTIVE'
                                   LIMIT 1;";

            using (var command = DatabaseHelper.CreateCommand(connection, query, new Dictionary<string, object>(), transaction))
            {
                object value = command.ExecuteScalar();
                if (value != null && value != DBNull.Value)
                {
                    return Convert.ToInt32(value);
                }
            }

            return 3;
        }

        private static void ExecuteDelete(MySql.Data.MySqlClient.MySqlConnection connection, MySql.Data.MySqlClient.MySqlTransaction transaction, string query, int groupId)
        {
            using (var command = DatabaseHelper.CreateCommand(connection, query, new Dictionary<string, object> { { "@groupId", groupId } }, transaction))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
