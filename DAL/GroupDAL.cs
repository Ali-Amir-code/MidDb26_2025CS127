using MidDb26_2025CS127.Models;
using MidDb26_2025CS127.Utilities;
using MySql.Data.MySqlClient;
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

        public static List<Project> GetProjectsForAssignment(int? currentGroupId)
        {
            var projects = new List<Project>();
            const string query = @"SELECT p.Id, p.Title
                                   FROM project AS p
                                   WHERE NOT EXISTS (
                                       SELECT 1
                                       FROM groupproject AS gp
                                       WHERE gp.ProjectId = p.Id
                                         AND (@currentGroupId IS NULL OR gp.GroupId <> @currentGroupId)
                                   )
                                   ORDER BY p.Title;";

            using (var reader = DatabaseHelper.GetData(query, new Dictionary<string, object>
            {
                { "@currentGroupId", currentGroupId.HasValue ? (object)currentGroupId.Value : DBNull.Value }
            }))
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

        public static List<Student> GetAvailableStudentsForGroup(int? currentGroupId)
        {
            var students = new List<Student>();
            const string query = @"SELECT s.Id, s.RegistrationNo, p.FirstName, p.LastName
                                   FROM student AS s
                                   JOIN person AS p ON p.Id = s.Id
                                   WHERE NOT EXISTS (
                                       SELECT 1
                                       FROM groupstudent AS gs
                                       WHERE gs.StudentId = s.Id
                                         AND (@currentGroupId IS NULL OR gs.GroupId <> @currentGroupId)
                                   )
                                   ORDER BY s.RegistrationNo;";

            using (var reader = DatabaseHelper.GetData(query, new Dictionary<string, object>
            {
                { "@currentGroupId", currentGroupId.HasValue ? (object)currentGroupId.Value : DBNull.Value }
            }))
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

                        UpsertGroupRelations(connection, transaction, (int)groupId, group.ProjectId, group.Members);

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

        public static bool UpdateGroup(Group group)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        UpsertGroupRelations(connection, transaction, group.Id, group.ProjectId, group.Members);
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

        private static void UpsertGroupRelations(MySqlConnection connection, MySqlTransaction transaction, int groupId, int? projectId, List<Student> members)
        {
            ExecuteDelete(connection, transaction, "DELETE FROM groupproject WHERE GroupId = @groupId;", groupId);

            if (projectId.HasValue && projectId.Value > 0)
            {
                using (var projectCommand = DatabaseHelper.CreateCommand(connection,
                    "INSERT INTO groupproject (ProjectId, GroupId, AssignmentDate) VALUES (@projectId, @groupId, @date);",
                    new Dictionary<string, object>
                    {
                        { "@projectId", projectId.Value },
                        { "@groupId", groupId },
                        { "@date", DateTime.Now }
                    }, transaction))
                {
                    projectCommand.ExecuteNonQuery();
                }
            }

            ExecuteDelete(connection, transaction, "DELETE FROM groupstudent WHERE GroupId = @groupId;", groupId);
            int activeStatus = GetActiveStudentStatusId(connection, transaction);

            foreach (var student in members ?? new List<Student>())
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
        }

        private static int GetActiveStudentStatusId(MySqlConnection connection, MySqlTransaction transaction)
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

        private static void ExecuteDelete(MySqlConnection connection, MySqlTransaction transaction, string query, int groupId)
        {
            using (var command = DatabaseHelper.CreateCommand(connection, query, new Dictionary<string, object> { { "@groupId", groupId } }, transaction))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
