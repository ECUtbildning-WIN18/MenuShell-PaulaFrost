using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuShell.Domain;
using MenuShell.Service;

namespace MenuShelll.Service
{
    class SQLSearch
    {
        public User SearchUser(string choice)
        {
            string queryString = "SELECT * FROM [User]";

            using (var connection = new SqlConnection(DatabaseHelper.connectionString))
            {
                var sqlCommand = new SqlCommand(queryString, connection);

                connection.Open();

                var reader = sqlCommand.ExecuteReader();

                User user;

                while (reader.Read())
                {
                    if (reader["UserName"].ToString().Contains(choice))
                    {
                        Console.WriteLine($"{reader[0]}");
                    }
                }
                reader.Close();
            }

            return null;
        }
    }
}
