using MenuShell.View;
using System;

namespace MenuShell.View
{
    class SystemAdministrator : ConsoleView
    {
        public override string Display()
        {
            base.Display();

            Console.WriteLine("(1) Add user");
            Console.WriteLine("(2) Exit");

            return "";

            //switch 
        }
    }
}
