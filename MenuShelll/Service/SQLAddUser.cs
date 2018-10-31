using System;
using System.Data.SqlClient;
using MenuShell.Domain;

namespace MenuShell.Service
{
    class SQLAddUser
    {
        public object AddUser(User user)
        {
            string sqlQuery = String.Format(
                "INSERT into [User](UserName, Password, Role) VALUES('{0}', '{1}', '{2}');" +
                "Select Identity", user.UserName, user.Password, user.Role);

            SqlConnection connection = new SqlConnection(DatabaseHelper.connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            var newUser = command.ExecuteScalar();

            command.Dispose();
            connection.Close();
            connection.Dispose();

            return newUser;
        }
    }
}
