using MenuShell.View;
using System;

namespace MenuShell.View
{
    class ReceptionistMainMenueView : ConsoleView
    {
        public override string Display()
        {
            base.Display();

            Console.WriteLine("(1) List users");
            Console.WriteLine("(2) Exit");

            var consoleKeyInfo = Console.ReadKey(true);

            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.D1:
                    return "1";
                case ConsoleKey.D2:
                    return "2";
                default:
                    return "";
            }
        }
    }
}
