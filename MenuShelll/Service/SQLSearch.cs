using System;
using System.Data.SqlClient;
using System.Threading;

namespace MenuShell.Service
{
    class SQLSearch
    {
        public void SearchUser(string choice)
        {
            string queryString = "SELECT * FROM [User]";

            var count = 0;

            using (var connection = new SqlConnection(DatabaseHelper.connectionString))
            {
                var sqlCommand = new SqlCommand(queryString, connection);

                connection.Open();

                var reader = sqlCommand.ExecuteReader();

                Console.WriteLine("Result:");

                while (reader.Read())
                {
                    if (reader["UserName"].ToString().Contains(choice))
                    {
                        Console.WriteLine($"{reader[0]}");
                        count += 1;
                    }
                }

                reader.Close();
            }

            if (count < 1)
            {
                Console.WriteLine($"No users found matching the search term {choice}");
                Thread.Sleep(2000);
            }
            else if (count >= 1)
            {
                Console.Write("\n(D)elete>");
                var consoleKeyInfo = Console.ReadKey(true);

                if (consoleKeyInfo.Key == ConsoleKey.D)
                {
                    ClearLine();
                    Console.Write("Delete> ");

                    using (var connection = new SqlConnection(DatabaseHelper.connectionString))
                    {
                        queryString = "SELECT * FROM [User]";

                        var sqlCommand = new SqlCommand(queryString, connection);
                        connection.Open();

                        var reader = sqlCommand.ExecuteReader();

                        var secChoice = Console.ReadLine();

                        while (reader.Read())
                        {
                            DeleteUser(secChoice, reader);
                        }

                        reader.Close();
                    }
                }
            }
        }

        public void DeleteUser(string s, SqlDataReader reader)
        {
            using (var connection = new SqlConnection(DatabaseHelper.connectionString))
            {
                connection.Open();

                if (reader["UserName"].ToString().Contains(s))
                {
                Console.WriteLine($"Delete user {s}? (Y)es (N)o");
                var consoleKeyInfo2 = Console.ReadKey(true);

                switch (consoleKeyInfo2.Key)
                {
                    case ConsoleKey.Y:

                        var sqlQuery = string.Format("DELETE from [User] WHERE [UserName] = '{0}'", s);

                        var command = new SqlCommand(sqlQuery, connection);
                        command.ExecuteNonQuery();
                        command.Dispose();
                        connection.Close();
                        connection.Dispose();

                        Console.WriteLine($"User {s} successfully deleted.");
                        Thread.Sleep(2000);
                        return;
                    case ConsoleKey.N:
                        break;
                    }
                }
            }
        }

        public static void ClearLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
