using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MenuShell.Domain;
using MenuShell.Service;
using MenuShell.View;

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

                User user;

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
                    //ClearLine();
                    Console.Write("Delete>");
                    var secChoice = Console.ReadLine();
                    if (_users.ContainsKey(secChoice))
                    {
                        Console.WriteLine($"Delete user {secChoice}? (Y)es (N)o");
                        var consoleKeyInfo2 = Console.ReadKey(true);

                        switch (consoleKeyInfo2.Key)
                        {
                            case ConsoleKey.Y:
                                _users.Remove(secChoice);
                                Console.WriteLine($"User {secChoice} successfully deleted.");
                                Thread.Sleep(2000);
                                isRunning = false;
                                break;
                            case ConsoleKey.N:
                                isRunning = false;
                                break;
                        }
                    }
                }
            }
        }
    }
}
