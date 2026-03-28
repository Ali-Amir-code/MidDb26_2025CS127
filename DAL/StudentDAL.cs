using MidDb26_2025CS127.Models;
using MidDb26_2025CS127.Utilities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace MidDb26_2025CS127.DAL
{
    internal class StudentDAL
    {

        public static List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            string query = "SELECT p.Id, RegistrationNo, FirstName, LastName, Email, Contact, DateOfBirth, Gender FROM student AS s JOIN person AS p ON p.Id=s.Id;";


            using (var reader = DatabaseHelper.GetData(query, new Dictionary<string, object>()))
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {   
                            Id = int.Parse(reader["Id"].ToString()),
                            StudentId = int.Parse(reader["Id"].ToString()),
                            RegistrationNo = reader["RegistrationNo"].ToString(),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Contact = reader["Contact"].ToString(),
                            DateOfBirth = reader["DateOfBirth"] as DateTime?,
                            Gender = reader["Gender"] as int?
                        });
                    }
                }
            

            return students;
        }


        public static bool AddStudent(Student student)
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
                        using (var personCommand = DatabaseHelper.CreateCommand(connection, personQuery, CreatePersonParameters(student), transaction))
                        {
                            personCommand.ExecuteNonQuery();
                            personId = personCommand.LastInsertedId;
                        }

                        const string studentQuery = @"INSERT INTO student (Id, RegistrationNo)
                                                      VALUES (@id, @registrationNo);";
                        using (var studentCommand = DatabaseHelper.CreateCommand(connection, studentQuery, new Dictionary<string, object>
                        {
                            { "@id", personId },
                            { "@registrationNo", student.RegistrationNo }
                        }, transaction))
                        {
                            studentCommand.ExecuteNonQuery();
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

        public static bool UpdateStudent(Student student)
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
                        var personParameters = CreatePersonParameters(student);
                        personParameters.Add("@id", student.Id);
                        using (var personCommand = DatabaseHelper.CreateCommand(connection, personQuery, personParameters, transaction))
                        {
                            personCommand.ExecuteNonQuery();
                        }

                        const string studentQuery = @"UPDATE student
                                                      SET RegistrationNo = @registrationNo
                                                      WHERE Id = @id;";
                        using (var studentCommand = DatabaseHelper.CreateCommand(connection, studentQuery, new Dictionary<string, object>
                        {
                            { "@registrationNo", student.RegistrationNo },
                            { "@id", student.Id }
                        }, transaction))
                        {
                            studentCommand.ExecuteNonQuery();
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

        public static bool DeleteStudent(int studentId)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (var groupMemberDelete = DatabaseHelper.CreateCommand(connection, "DELETE FROM groupstudent WHERE StudentId = @id;", new Dictionary<string, object> { { "@id", studentId } }, transaction))
                        {
                            groupMemberDelete.ExecuteNonQuery();
                        }

                        using (var studentDelete = DatabaseHelper.CreateCommand(connection, "DELETE FROM student WHERE Id = @id;", new Dictionary<string, object> { { "@id", studentId } }, transaction))
                        {
                            studentDelete.ExecuteNonQuery();
                        }

                        using (var personDelete = DatabaseHelper.CreateCommand(connection, "DELETE FROM person WHERE Id = @id;", new Dictionary<string, object> { { "@id", studentId } }, transaction))
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

        private static Dictionary<string, object> CreatePersonParameters(Student student)
        {
            return new Dictionary<string, object>
            {
                { "@firstName", student.FirstName },
                { "@lastName", string.IsNullOrWhiteSpace(student.LastName) ? (object)DBNull.Value : student.LastName },
                { "@contact", string.IsNullOrWhiteSpace(student.Contact) ? (object)DBNull.Value : student.Contact },
                { "@email", student.Email },
                { "@dateOfBirth", student.DateOfBirth },
                { "@gender", student.Gender }
            };
        }
    }
}
