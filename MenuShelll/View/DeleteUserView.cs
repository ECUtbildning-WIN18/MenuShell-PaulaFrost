using System;
using System.Collections.Generic;
using MenuShell.Domain;

namespace MenuShell.View
{
    class DeleteUserView : ConsoleView
    {
        //private readonly IDictionary<string, User> _users;

        //public DeleteUserView(IDictionary<string, User> users)
        //{
        //    _users = users;
        //}

        private readonly IList<User> _users;

        public DeleteUserView(IList<User> users)
        {
            _users = users;
        }

        public override void Display()
        {
            bool isRunning = true;

            do
            {
                base.Display();

                //Console.WriteLine("# User list\n");
                //foreach (var user in _users)
                //{
                //    Console.WriteLine(user.Value.UserName);
                //}

                //Console.WriteLine("\nChoose one user");
                //var choice = Console.ReadLine();

                //if (_users.ContainsKey(choice))
                //{
                //    _users.Remove(choice);
                //}
                //else
                //{
                //    isRunning = false;
                //}

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
