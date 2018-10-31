using System;
using System.Collections.Generic;
using MenuShell.Domain;

namespace MenuShell.View
{
    class ListUsersView : ConsoleView
    {
        //private readonly IDictionary<string, User> _users;

        //public ListUsersView(IDictionary<string, User> users)
        //{
        //    _users = users;
        //}

        private readonly IList<User> _users;

        public ListUsersView(IList<User> users)
        {
            _users = users;
        }

        public override void Display()
        {
            bool isRunning = true;

            do
            {
                //base.Display();

                //Console.WriteLine("# User list\n");
                //foreach (var user in _users)
                //{
                //    Console.WriteLine(user.Value.UserName);
                //}

                //Console.WriteLine("\nPress Escape to get back..");
                //var consoleKeyInfo = Console.ReadKey();

                //if (consoleKeyInfo.Key == ConsoleKey.Escape)
                //{
                //    isRunning = false;
                //}

            } while (isRunning);
        }
    }
}
