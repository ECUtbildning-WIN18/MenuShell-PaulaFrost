using System;
using System.Collections.Generic;
using System.Threading;
using MenuShell.Domain;
using MenuShell.EntityFramework;
using MenuShell.Service;

namespace MenuShell.View
{
    class SearchUserView : ConsoleView
    {
        public override void Display()
        {
            var isRunning = true;
            var count = 0;
            var entityHelp = new HelperEF();

            base.Display();

            Console.WriteLine("Search by username:");
            Console.Write(">");

            var choice = Console.ReadLine();

            var getUsers = entityHelp.GetUser();

            foreach (var user in getUsers)
            {
                if (user.UserName.Contains(choice))
                {
                    Console.WriteLine(user.UserName);
                    count += 1;
                }
            }

            if (count < 1)
            {
                Console.WriteLine($"No users found matching the search term {choice}");
                Thread.Sleep(2000);
                isRunning = false;
            }
            else if (count >= 1)
            {
                //Console.Write("\n(D)elete>");
                //var consoleKeyInfo = Console.ReadKey(true);

                //if (consoleKeyInfo.Key == ConsoleKey.D)
                //{
                //    ClearLine();
                //    Console.Write("Delete>");
                //    var secChoice = Console.ReadLine();
                //    if (users.ContainsKey(secChoice))
                //    {
                //        Console.WriteLine($"Delete user {secChoice}? (Y)es (N)o");
                //        var consoleKeyInfo2 = Console.ReadKey(true);

                //        switch (consoleKeyInfo2.Key)
                //        {
                //            case ConsoleKey.Y:
                //                users.Remove(secChoice);
                //                Console.WriteLine($"User {secChoice} successfully deleted.");
                //                Thread.Sleep(2000);
                //                isRunning = false;
                //                break;
                //            case ConsoleKey.N:
                //                isRunning = false;
                //                break;
                //        }
                //    }
                //}
            }
        }    
        




        public static void ClearLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
