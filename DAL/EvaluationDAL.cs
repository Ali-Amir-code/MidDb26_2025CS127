using MidDb26_2025CS127.Models;
using MidDb26_2025CS127.Utilities;
using System;
using System.Collections.Generic;

namespace MidDb26_2025CS127.DAL
{
    internal class EvaluationDAL
    {
        public static List<Evaluation> GetAllEvaluations()
        {
            var list = new List<Evaluation>();
            const string query = "SELECT Id, Name, TotalMarks, TotalWeightage FROM evaluation ORDER BY Id DESC;";
            using (var reader = DatabaseHelper.GetData(query, new Dictionary<string, object>()))
            {
                while (reader.Read())
                {
                    list.Add(new Evaluation
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = Convert.ToString(reader["Name"]),
                        TotalMarks = Convert.ToInt32(reader["TotalMarks"]),
                        TotalWeightage = Convert.ToInt32(reader["TotalWeightage"])
                    });
                }
            }
            return list;
        }

        public static bool AddEvaluation(Evaluation evaluation)
        {
            EnsureEvaluationNameLookupEntry(evaluation.Name);

            const string query = @"INSERT INTO evaluation (Name, TotalMarks, TotalWeightage)
                                   VALUES (@name, @totalMarks, @weightage);";
            return DatabaseHelper.Update(query, new Dictionary<string, object>
            {
                { "@name", evaluation.Name },
                { "@totalMarks", evaluation.TotalMarks },
                { "@weightage", evaluation.TotalWeightage }
            }) > 0;
        }

        public static List<EvaluationMarkRow> GetEvaluationMarkRows(int evaluationId)
        {
            var rows = new List<EvaluationMarkRow>();
            const string query = @"SELECT ge.GroupId,
                                          p.Title AS ProjectTitle,
                                          ge.EvaluationDate,
                                          ge.ObtainedMarks
                                   FROM groupevaluation AS ge
                                   LEFT JOIN groupproject AS gp ON gp.GroupId = ge.GroupId
                                   LEFT JOIN project AS p ON p.Id = gp.ProjectId
                                   WHERE ge.EvaluationId = @evaluationId
                                   ORDER BY ge.EvaluationDate DESC;";
            using (var reader = DatabaseHelper.GetData(query, new Dictionary<string, object> { { "@evaluationId", evaluationId } }))
            {
                while (reader.Read())
                {
                    rows.Add(new EvaluationMarkRow
                    {
                        GroupId = Convert.ToInt32(reader["GroupId"]),
                        ProjectTitle = Convert.ToString(reader["ProjectTitle"]),
                        EvaluationDate = Convert.ToDateTime(reader["EvaluationDate"]),
                        ObtainedMarks = Convert.ToInt32(reader["ObtainedMarks"])
                    });
                }
            }
            return rows;
        }

        private static void EnsureEvaluationNameLookupEntry(string evaluationName)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                const string existsQuery = @"SELECT COUNT(1) FROM lookup
                                             WHERE UPPER(Category) = 'EVALUATION_NAME'
                                               AND UPPER(Value) = UPPER(@value);";
                using (var existsCommand = DatabaseHelper.CreateCommand(connection, existsQuery, new Dictionary<string, object> { { "@value", evaluationName } }))
                {
                    long count = Convert.ToInt64(existsCommand.ExecuteScalar());
                    if (count > 0) return;
                }

                const string insertQuery = "INSERT INTO lookup (Category, Value) VALUES ('EVALUATION_NAME', @value);";
                using (var insertCommand = DatabaseHelper.CreateCommand(connection, insertQuery, new Dictionary<string, object> { { "@value", evaluationName } }))
                {
                    insertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
