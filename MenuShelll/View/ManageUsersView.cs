using System;
using System.Collections.Generic;
using MenuShell.Domain;

namespace MenuShell.View
{
    class ManageUsersView : ConsoleView
    {
        private readonly IDictionary<string, User> _users;

        public ManageUsersView(IDictionary<string, User> users)
        {
            _users = users;
        }

        public override string Display()
        {
            bool isRunning = true;

            do
            {
                base.Display();

                Console.WriteLine("1. Add user");
                Console.WriteLine("2. Delete user");

                Console.WriteLine("\n>");

                WriteAt("", 1, 3);
                var consoleKeyInfo = Console.ReadKey(true);

                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.D1:
                        var addUser = new AddUserView(_users);
                        addUser.Display();

                        foreach (var user in _users)
                        {
                            Console.WriteLine(user.Value.UserName);
                        }

                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        var deleteUser = new DeleteUserView(_users);
                        deleteUser.Display();
                        break;
                    case ConsoleKey.Escape:
                        isRunning = false;
                        break;
                    default:
                        break;
                }

            } while (isRunning);

            return "";
        }

        public static int xCoord, yCoord, y;

        static void WriteAt(string s, int x, int y)
        {
            Console.SetCursorPosition(xCoord + x, yCoord + y);
            Console.Write(s);
        }
    }
}
