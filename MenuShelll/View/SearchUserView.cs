using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using MenuShell.Domain;
using MenuShell.View;

namespace MenuShell.View
{
    class SearchUserView : ConsoleView
    {
        private readonly IDictionary<string, User> _users;

        public SearchUserView(IDictionary<string, User> users)
        {
            _users = users;
        }

        public override string Display()
        {
            var isRunning = true;

            do
            {
                base.Display();

                Console.WriteLine("Search by username:");
                Console.Write(">");

                var choice = Console.ReadLine();

                foreach (var user in _users)
                {    
                    if (user.Value.UserName == choice)
                    {
                        Console.WriteLine(user.Key);
                    }
                    else if(!_users.ContainsKey(choice))
                    {
                        Console.WriteLine($"No users found matching the search term {choice}");
                        Thread.Sleep(2000);
                        isRunning = false;
                    }
                }

                Console.WriteLine($"Delete user {choice}");

            } while (isRunning);

            return "";
        }
    }
}
