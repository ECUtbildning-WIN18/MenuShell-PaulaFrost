using System;
using System.Collections.Generic;
using MenuShell.Domain;
using MenuShell.Service;

namespace MenuShell.View
{
    class SystemAdministratorView : ConsoleView
    {
        //private readonly IDictionary<string, User> _users;
        //private readonly IAuthenticationService authenticationService;

        //public SystemAdministratorView(IDictionary<string, User> users)
        //{
        //    _users = users;
        //}

        //private readonly IList<User> _users;

        //public SystemAdministratorView(IList<User> users)
        //{
        //    _users = users;
        //}

        public override void Display()
        {
            bool isRunning = true;

            do
            {
                base.Display();
                Console.WriteLine("# Admin menu\n");
                Console.WriteLine("(1) Manage users");
                Console.WriteLine("(2) Exit");

                Console.WriteLine("\n>");

                WriteAt(" ", 1, 5);
                var consoleKeyInfo = Console.ReadKey(true);

                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.D1:
                        var manageUser = new ManageUsersView(/*_users*/);
                        manageUser.Display();
                        break;
                    case ConsoleKey.D2:
                        var authenticateUsers = new SQLLogin();
                        //var backToLogin = new LoginView(authenticateUsers);
                        //backToLogin.Display();
                        isRunning = false;
                        break;
                    default:
                        break;
                }

            } while (isRunning);
        }

        public static int xCoord, yCoord, y;

        static void WriteAt(string s, int x, int y)
        {
            Console.SetCursorPosition(xCoord + x, yCoord + y);
            Console.Write(s);
        }
    }
}
