using System;
using System.Collections.Generic;
using MenuShell.Domain;
using MenuShell.EntityFramework;
using MenuShell.Service;

namespace MenuShell.View
{
    class SystemAdministratorView : ConsoleView
    {
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
                        var manageUser = new ManageUsersView();
                        manageUser.Display();
                        break;
                    case ConsoleKey.D2:
                        var backToLogin = new LoginView();
                        backToLogin.Display();
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
