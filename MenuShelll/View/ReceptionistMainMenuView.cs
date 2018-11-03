using System;
using System.Collections.Generic;
using MenuShell.Domain;

namespace MenuShell.View
{
    class ReceptionistMainMenuView : ConsoleView
    {
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
                        var listUsers = new ListUsersView();
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
