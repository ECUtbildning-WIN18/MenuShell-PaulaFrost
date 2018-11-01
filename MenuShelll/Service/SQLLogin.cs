using System;
using System.Data.SqlClient;
using MenuShell.Domain;

namespace MenuShell.Service
{
    public class SQLLogin
    {
        public User AuthenticateUser(string username, string password)
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
                    if (reader["UserName"].ToString() == username && reader["Password"].ToString() == password)
                    {
                        var role = reader["Role"].ToString();

                        if(Enum.TryParse(role, out Role result))
                        {
                            user = new User(username, password, result);

                            return user;
                        }  
                    }   
                }
                reader.Close();
            }

            return null;
        }
    }
}
