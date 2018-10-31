using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.Service
{
    class SQLDisplayUser
    {
        public void DisplayUsers()
        {
            string connectionString = "Data Source=(local); Initial Catalog=MenuShellDB; Integrated Security=true";

            string queryString = "SELECT * FROM [User]";

            using (var connection = new SqlConnection(connectionString))
            {
                var sqlCommand = new SqlCommand(queryString, connection);

                connection.Open();

                var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"{reader[0]}, {reader[1]}, {reader[2]}");
                }

                reader.Close();
            }
        }
    }
}
