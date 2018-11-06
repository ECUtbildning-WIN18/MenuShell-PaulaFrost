using System;
using MenuShell.EntityFramework;

namespace MenuShell.View
{
    class ListUsersView : ConsoleView
    {
        public override void Display()
        {
            bool isRunning = true;

            do
            {
                var entityHelper = new HelperEF();

                entityHelper.ListUsers();

                Console.WriteLine("\nPress any key to go back...");
                Console.ReadKey();

                isRunning = false;

            } while (isRunning);
        }
    }
}
