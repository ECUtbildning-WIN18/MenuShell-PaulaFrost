using System;

namespace MenuShell.View
{
    class ManageUsersView : ConsoleView
    {
        public override void Display()
        {
            bool isRunning = true;

            do
            {
                base.Display();

                Console.WriteLine("# Manage user\n");
                Console.WriteLine("1. Add user");
                Console.WriteLine("2. Search user");

                Console.WriteLine("\n>");

                WriteAt("", 1, 5);
                var consoleKeyInfo = Console.ReadKey(true);

                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.D1:

                        var addUser = new AddUserView();
                        addUser.Display();
                        break;

                    case ConsoleKey.D2:
                        var searchUser = new SearchUserView();
                        searchUser.Display();
                        break;

                    case ConsoleKey.Escape:
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
