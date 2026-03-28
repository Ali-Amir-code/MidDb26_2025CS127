using MidDb26_2025CS127.Models;
using MidDb26_2025CS127.Utilities;
using System;
using System.Collections.Generic;

namespace MidDb26_2025CS127.DAL
{
    internal class AdvisorDAL
    {
        public static List<Advisor> GetAllAdvisors()
        {
            var advisors = new List<Advisor>();
            const string query = @"SELECT p.Id, p.FirstName, p.LastName, p.Contact, p.Email, p.DateOfBirth, p.Gender,
                                          a.Designation, a.Salary, l.Value AS DesignationValue
                                   FROM advisor AS a
                                   JOIN person AS p ON p.Id = a.Id
                                   LEFT JOIN lookup AS l ON l.Id = a.Designation;";

            using (var reader = DatabaseHelper.GetData(query, new Dictionary<string, object>()))
            {
                while (reader.Read())
                {
                    advisors.Add(new Advisor
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        AdvisorId = Convert.ToInt32(reader["Id"]),
                        FirstName = Convert.ToString(reader["FirstName"]),
                        LastName = Convert.ToString(reader["LastName"]),
                        Contact = Convert.ToString(reader["Contact"]),
                        Email = Convert.ToString(reader["Email"]),
                        DateOfBirth = reader["DateOfBirth"] as DateTime?,
                        Gender = reader["Gender"] as int?,
                        Designation = Convert.ToInt32(reader["Designation"]),
                        Salary = reader["Salary"] as decimal?,
                        DesignationLabel = Convert.ToString(reader["DesignationValue"])
                    });
                }
            }

            return advisors;
        }

        public static List<Lookup> GetDesignationLookups()
        {
            var values = new List<Lookup>();
            const string query = @"SELECT Id, Value, Category
                                   FROM lookup
                                   WHERE UPPER(Category) LIKE '%DESIGNATION%'
                                   ORDER BY Value;";

            using (var reader = DatabaseHelper.GetData(query, new Dictionary<string, object>()))
            {
                while (reader.Read())
                {
                    values.Add(new Lookup
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Value = Convert.ToString(reader["Value"]),
                        Category = Convert.ToString(reader["Category"])
                    });
                }
            }

            return values;
        }

        public static bool AddAdvisor(Advisor advisor)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        const string personQuery = @"INSERT INTO person (FirstName, LastName, Contact, Email, DateOfBirth, Gender)
                                                     VALUES (@firstName, @lastName, @contact, @email, @dateOfBirth, @gender);";

                        long personId;
                        using (var personCommand = DatabaseHelper.CreateCommand(connection, personQuery, CreatePersonParameters(advisor), transaction))
                        {
                            personCommand.ExecuteNonQuery();
                            personId = personCommand.LastInsertedId;
                        }

                        const string advisorQuery = @"INSERT INTO advisor (Id, Designation, Salary)
                                                      VALUES (@id, @designation, @salary);";
                        using (var advisorCommand = DatabaseHelper.CreateCommand(connection, advisorQuery, new Dictionary<string, object>
                        {
                            { "@id", personId },
                            { "@designation", advisor.Designation },
                            { "@salary", advisor.Salary }
                        }, transaction))
                        {
                            advisorCommand.ExecuteNonQuery();
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

        public static bool UpdateAdvisor(Advisor advisor)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        const string personQuery = @"UPDATE person
                                                     SET FirstName = @firstName,
                                                         LastName = @lastName,
                                                         Contact = @contact,
                                                         Email = @email,
                                                         DateOfBirth = @dateOfBirth,
                                                         Gender = @gender
                                                     WHERE Id = @id;";

                        var personParameters = CreatePersonParameters(advisor);
                        personParameters.Add("@id", advisor.Id);
                        using (var personCommand = DatabaseHelper.CreateCommand(connection, personQuery, personParameters, transaction))
                        {
                            personCommand.ExecuteNonQuery();
                        }

                        const string advisorQuery = @"UPDATE advisor
                                                      SET Designation = @designation,
                                                          Salary = @salary
                                                      WHERE Id = @id;";
                        using (var advisorCommand = DatabaseHelper.CreateCommand(connection, advisorQuery, new Dictionary<string, object>
                        {
                            { "@designation", advisor.Designation },
                            { "@salary", advisor.Salary },
                            { "@id", advisor.Id }
                        }, transaction))
                        {
                            advisorCommand.ExecuteNonQuery();
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

        public static bool DeleteAdvisor(int advisorId)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (var projectAdvisorDelete = DatabaseHelper.CreateCommand(connection, "DELETE FROM projectadvisor WHERE AdvisorId = @id;", new Dictionary<string, object> { { "@id", advisorId } }, transaction))
                        {
                            projectAdvisorDelete.ExecuteNonQuery();
                        }

                        using (var advisorDelete = DatabaseHelper.CreateCommand(connection, "DELETE FROM advisor WHERE Id = @id;", new Dictionary<string, object> { { "@id", advisorId } }, transaction))
                        {
                            advisorDelete.ExecuteNonQuery();
                        }

                        using (var personDelete = DatabaseHelper.CreateCommand(connection, "DELETE FROM person WHERE Id = @id;", new Dictionary<string, object> { { "@id", advisorId } }, transaction))
                        {
                            personDelete.ExecuteNonQuery();
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

        private static Dictionary<string, object> CreatePersonParameters(Advisor advisor)
        {
            return new Dictionary<string, object>
            {
                { "@firstName", advisor.FirstName },
                { "@lastName", string.IsNullOrWhiteSpace(advisor.LastName) ? (object)DBNull.Value : advisor.LastName },
                { "@contact", string.IsNullOrWhiteSpace(advisor.Contact) ? (object)DBNull.Value : advisor.Contact },
                { "@email", advisor.Email },
                { "@dateOfBirth", advisor.DateOfBirth },
                { "@gender", advisor.Gender }
            };
        }
    }
}
