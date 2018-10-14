using MenuShell.View;
using System;

namespace MenuShell.View
{
    class SystemAdministratorView : ConsoleView
    {
        public override string Display()
        {
            bool isRunning = true;

            do
            {
                base.Display();

                Console.WriteLine("(1) Administer users");
                Console.WriteLine("(2) Exit");

                var consoleKeyInfo = Console.ReadKey(true);

                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.D1:
                        var createUser = new CreateUserView();
                        createUser.Display();
                        break;
                    case ConsoleKey.D2:
                        isRunning = false;
                        break;
                    default:
                        break;
                }

            } while (isRunning);
            
            return "";
        }
    }
}
