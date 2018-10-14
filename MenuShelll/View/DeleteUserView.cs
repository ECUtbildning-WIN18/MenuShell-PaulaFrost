using System;
using System.Collections.Generic;
using MenuShell.Domain;

namespace MenuShell.View
{
    class DeleteUserView : ConsoleView
    {
        private readonly IDictionary<string, User> _users;

        public DeleteUserView(IDictionary<string, User> users)
        {
            _users = users;
        }

        public override string Display()
        {
            bool isRunning = true;

            do
            {
                base.Display();

                foreach (var user in _users)
                {
                    Console.WriteLine(user.Value.UserName);
                }

                var choice = Console.ReadLine();

                if (_users.ContainsKey(choice))
                {
                    _users.Remove(choice);
                }
                else
                {
                    isRunning = false;
                }

            } while (isRunning);

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
