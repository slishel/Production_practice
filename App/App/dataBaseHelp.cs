using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static App.Mod;

namespace App
{
    internal class dataBaseHelp
    {
        private readonly string _connectionString;
        public dataBaseHelp()
        {
            // Строка подключения к базе данных
            _connectionString = "Data Source=DESKTOP-0OUFJ0C;Initial Catalog=BD_dd;Integrated Security=True;";
        }

        public DataTable ExecuteSqlQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    try
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при выполнении запроса: {ex.Message}");
                    }
                }
            }
            return dataTable;
        }

        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    try
                    {
                        connection.Open();
                        return command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при выполнении запроса: {ex.Message}");
                        throw;
                    }
                }
            }
        }
        public User AuthenticateUser(string username, string password)
        {
            User user = null;

            string query = "SELECT id, username, nameRole, FIO FROM Users WHERE username = @username AND password = @password"; // Храните пароли в захешированном виде
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@username", username),
        new SqlParameter("@password", password)
            };

            DataTable result = ExecuteSqlQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                user = new User
                {
                    id = Convert.ToInt32(result.Rows[0]["id"]),
                    username = result.Rows[0]["username"].ToString(),
                    nameRole = result.Rows[0]["nameRole"].ToString(),
                    FIO = result.Rows[0]["FIO"].ToString()
                };
            }

            return user;
        }
    

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Users";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User
                            {
                                id = Convert.ToInt32(reader["id"]),
                                FIO = reader["FIO"].ToString(),
                                username = reader["username"].ToString(),
                                nameRole = reader["nameRole"].ToString(),
                                password = reader["password"].ToString()
                            };
                            users.Add(user);
                        }
                    }
                }
            }
            return users;
        }

    }
}
