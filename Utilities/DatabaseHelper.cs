using MidDb26_2025CS127.UI.UtilityForms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidDb26_2025CS127.Utilities
{
    public enum DatabaseStatus
    {
        Connected,
        Disconnected,
    }
    internal class DatabaseHelper
    {
        private static string ServerName = "127.0.0.1";
        private static string Port = "3306";
        private static string DatabaseName = "projectadb";
        private static string DatabaseUser = "root";
        private static string DatabasePassword = "password";

        public static DatabaseStatus dbStatus;
       
        public static MySqlConnection GetConnection()
        {
            string connectionString = $"server={ServerName};port={Port};user={DatabaseUser};database={DatabaseName};password={DatabasePassword};SslMode=Required;";
            MySqlConnection connection;
            try
            {
            connection = new MySqlConnection($"server={ServerName};port={Port};user={DatabaseUser};database={DatabaseName};password={DatabasePassword};SslMode=Required;");
                dbStatus = DatabaseStatus.Connected;
                return connection;
            }
            catch
            {
                MessageBox.Show("Unable to connect to the database. Please enter your credentials and try again.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbStatus = DatabaseStatus.Disconnected;
                DatabaseCredForm dbCredForm = new DatabaseCredForm();
                dbCredForm.ShowDialog();
                if (dbCredForm.DialogResult == DialogResult.OK)
                {
                    ServerName = dbCredForm.ServerAddress;
                    Port = dbCredForm.Port;
                    DatabaseName = dbCredForm.DatabaseName;
                    DatabaseUser = dbCredForm.DatabaseUser;
                    DatabasePassword = dbCredForm.DatabasePassword;
                    connection = new MySqlConnection($"server={ServerName};port={Port};user={DatabaseUser};database={DatabaseName};password={DatabasePassword};SslMode=Required;");
                    dbStatus = DatabaseStatus.Connected;
                    return connection;
                }
                else
                {
                    MessageBox.Show("Unable to connect to the database. Please check your credentials and try again.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dbStatus = DatabaseStatus.Disconnected;
                    Application.Exit();
                    return null;
                }

            }
        }

        public static MySqlDataReader GetData(string query, Dictionary<string, object> parameters)
        {
            var connection = GetConnection();
            connection.Open();

            var command = new MySqlCommand(query, connection);

            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }
            }

            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public static int Update(string query, Dictionary<string, object> parameters)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    return command.ExecuteNonQuery();
                }
            }
        }

        public static MySqlCommand CreateCommand(MySqlConnection connection, string query, Dictionary<string, object> parameters, MySqlTransaction transaction = null)
        {
            var command = transaction == null
                ? new MySqlCommand(query, connection)
                : new MySqlCommand(query, connection, transaction);

            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    command.Parameters.AddWithValue(parameter.Key, parameter.Value ?? DBNull.Value);
                }
            }

            return command;
        }
    }
}

