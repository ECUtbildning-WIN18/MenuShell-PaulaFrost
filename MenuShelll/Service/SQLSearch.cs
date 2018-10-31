using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MenuShell.Domain;
using MenuShell.Service;

namespace MenuShell.Service
{
    class SQLSearch
    {
        public User SearchUser(string choice)
        {
            string queryString = "SELECT * FROM [User]";

            var count = 0;

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
                        count += 1;
                    }
                }
                reader.Close();

                if (count < 1)
                {
                    Console.WriteLine($"No users found matching the search term {choice}");
                    Thread.Sleep(2000);
                }
            }

            return null;
        }
    }
}
