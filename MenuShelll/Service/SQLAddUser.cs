using System;
using System.Data.SqlClient;
using MenuShell.Domain;

namespace MenuShell.Service
{
    class SQLAddUser
    {
        public void AddUser(User user)
        {
            using (var connection = new SqlConnection(DatabaseHelper.connectionString))
            {
                connection.Open();

                var sqlQuery = String.Format(
                    "INSERT into [User](UserName, Password, Role) VALUES('{0}', '{1}', '{2}');" +
                    "Select @@Identity", user.UserName, user.Password, user.Role);

                var command = new SqlCommand(sqlQuery, connection);

                command.ExecuteNonQuery(); //Här small det

                command.Dispose();
                connection.Close();
                connection.Dispose();
            }
        }
    }
}



