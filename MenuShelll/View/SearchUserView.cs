using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using MenuShell.Domain;
using MenuShell.Service;
using MenuShell.Service;

namespace MenuShell.View
{
    class SearchUserView : ConsoleView
    {
        //private readonly IDictionary<string, User> _users;

        //public SearchUserView(IDictionary<string, User> users)
        //{
        //    _users = users;
        //}

        private readonly IList<User> _users;

        public SearchUserView(IList<User> users)
        {
            _users = users;
        }

        public override void Display()
        {
            var isRunning = true;
            var count = 0;

            do
            {
                base.Display();

                Console.WriteLine("Search by username:");
                Console.Write(">");

                var choice = Console.ReadLine();

                var sqlSearch = new SQLSearch();

                sqlSearch.SearchUser(choice);

                

                //foreach(var user in _users)
                //{
                //    if (user.Value.UserName.Contains(choice))
                //    {
                //        Console.WriteLine(user.Value.UserName);
                //        //var searchResult = _users.Where(x => x.Value.UserName.Contains(choice));
                //        count += 1;
                //    }
                //}

                if (count < 1)
                {
                    Console.WriteLine($"No users found matching the search term {choice}");
                    Thread.Sleep(2000);
                    isRunning = false;
                }
                else if (count >= 1)
                {
                    Console.Write("\n(D)elete>");
                    var consoleKeyInfo = Console.ReadKey(true);

                    if (consoleKeyInfo.Key == ConsoleKey.D)
                    {
                        //ClearLine();
                        //Console.Write("Delete>");
                        //var secChoice = Console.ReadLine();
                        //if (_users.ContainsKey(secChoice))
                        //{
                        //    Console.WriteLine($"Delete user {secChoice}? (Y)es (N)o");
                        //    var consoleKeyInfo2 = Console.ReadKey(true);

                        //    switch (consoleKeyInfo2.Key)
                        //    {
                        //        case ConsoleKey.Y:
                        //            _users.Remove(secChoice);
                        //            Console.WriteLine($"User {secChoice} successfully deleted.");
                        //            Thread.Sleep(2000);
                        //            isRunning = false;
                        //            break;
                        //        case ConsoleKey.N:
                        //            isRunning = false;
                        //            break;
                        //    }
                        //}
                    }
                }

            } while (isRunning);
        }

        public static int xCoord, yCoord, y;

        static void WriteAt(string s, int x, int y)
        {
            Console.SetCursorPosition(xCoord + x, yCoord + y);
            Console.Write(s);
        }

        static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
}
