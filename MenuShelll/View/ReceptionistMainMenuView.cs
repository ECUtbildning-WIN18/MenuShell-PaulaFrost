using System;
using System.Collections.Generic;
using MenuShell.Domain;

namespace MenuShell.View
{
    class ReceptionistMainMenuView : ConsoleView
    {
        //private IDictionary<string, User> _users;

        //public ReceptionistMainMenuView(IDictionary<string, User> users)
        //{
        //    _users = users;
        //}

        private readonly IList<User> _users;

        public ReceptionistMainMenuView(IList<User> users)
        {
            _users = users;
        }

        public override void Display()
        {
            bool isRunning = true;

            do
            {
                base.Display();

                Console.WriteLine("# Receptionist ");
                Console.WriteLine("(1) List users");
                Console.WriteLine("(2) Exit");

                var consoleKeyInfo = Console.ReadKey(true);

                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.D1:
                        var listUsers = new ListUsersView(_users);
                        listUsers.Display();
                        break; 
                    case ConsoleKey.D2:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Choose between (1) or (2)..");
                        Console.ReadKey();
                        break;
                }

            } while (isRunning);
        }
    }
}
