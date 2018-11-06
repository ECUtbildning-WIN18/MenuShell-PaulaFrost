using System;
using System.Threading;
using MenuShell.EntityFramework;

namespace MenuShell.View
{
    class SearchUserView : ConsoleView
    {
        public override void Display()
        {
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
                    Console.WriteLine($"{user.UserName}");
                    count += 1;
                }
            }

            if (count < 1)
            {
                Console.WriteLine($"No users found matching the search term {choice}");
                Thread.Sleep(2000);
            }
            else if (count >= 1)
            {
                Console.Write("\n(D)elete>");

                var consoleKeyInfo = Console.ReadKey(true);

                if (consoleKeyInfo.Key == ConsoleKey.D)
                {
                    ClearLine();
                    Console.Write("Delete>");
                    var secChoice = Console.ReadLine();

                    foreach (var user in getUsers)
                    {
                        if (user.UserName.Contains(secChoice))
                        {
                            Console.WriteLine($"Delete user {secChoice}? (Y)es (N)o");
                            var consoleKeyInfo2 = Console.ReadKey(true);

                            switch (consoleKeyInfo2.Key)
                            {
                                case ConsoleKey.Y:
                                    entityHelp.DeleteUserByUsername(secChoice);

                                    Console.WriteLine($"User {secChoice} successfully deleted.");
                                    Thread.Sleep(2000);
                                    break;

                                case ConsoleKey.N:
                                    break;
                            }
                        }
                    }
                }
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
