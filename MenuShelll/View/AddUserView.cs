using MenuShell.Domain;
using System;
using System.Collections.Generic;

namespace MenuShell.View
{
    class AddUserView : ConsoleView
    {
        private readonly IDictionary<string, User> _users;

        public AddUserView(IDictionary<string, User> users)
        {
            _users = users;
        }

        public override string Display()
        {
            bool isRunning = true;

            do
            {
                base.Display();

                Console.WriteLine("# Add user\n");
                Console.WriteLine("Username:");
                Console.WriteLine("Password:");
                Console.WriteLine("Role:");

                WriteAt(" ", 9, 2);
                var username = Console.ReadLine();
                WriteAt(" ", 9, 3);
                var password = Console.ReadLine();
                WriteAt(" ", 9, 4);
                var role = Console.ReadLine();

                Console.WriteLine("Is this correct? (Y)es (N)o");

                var consoleKeyInfo = Console.ReadKey(true);

                var user = new User(username, password, (Role) Enum.Parse(typeof(Role), role));

                if (!_users.ContainsKey(user.UserName))
                {
                    _users.Add(user.UserName, user);

                    isRunning = false;
                }

            } while(isRunning);
            
            return " ";
        }

        public static int xCoord, yCoord, y;

        static void WriteAt(string s, int x, int y)
        {
            Console.SetCursorPosition(xCoord + x, yCoord + y);
            Console.Write(s);
        }
    }
}
