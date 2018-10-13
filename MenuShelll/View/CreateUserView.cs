using System;

namespace MenuShell.View
{
    class CreateUserView : ConsoleView
    {
        public override string Display()
        {
            base.Display();

            Console.WriteLine("Username:");
            Console.WriteLine("Password:");
            Console.WriteLine("Role:");

            var username = Console.ReadLine();
            var password = Console.ReadLine();
            var role = Console.ReadLine();

            return "";
        }
    }
}
