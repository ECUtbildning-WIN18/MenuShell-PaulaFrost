using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MenuShell.Domain;

namespace MenuShell.Service
{
    class SQLLoader : IUserLoader
    {
        public IList<User> UserLoaders()
        {
            List<User> result = new List<User>();

            string sqlQuery = String.Format("SELECT * from [User]");

            SqlConnection connection = new SqlConnection(DatabaseHelper.connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader dataReader = command.ExecuteReader();

            User user;

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    var username = dataReader["UserName"].ToString();
                    var password = dataReader["Password"].ToString();
                    var role = dataReader["Role"].ToString();

                    Enum.TryParse(role, out Role roleResult);

                    user = new User(username, password, roleResult);

                    result.Add(user);
                }
            }

            return result;
        }
    }
}
