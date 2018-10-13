using System;

namespace MenuShell.View
{
    class LoginView : ConsoleView
    {
        public override string Display()
        {
            bool loginSucceded = false;

            do
            {
                base.Display();

                Console.WriteLine("Please log in\n");
                Console.WriteLine("Username:");
                Console.WriteLine("Password:");

                string username = Console.ReadLine();
                string password = Console.ReadLine();

                Console.WriteLine("\nIs this correct? (Y)es (N)o");
                var keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Y)
                {

                }
                else if(keyInfo.Key == ConsoleKey.N)
                {
                    Console.WriteLine("Näähee");
                }
                else
                {
                    Console.WriteLine("Wrong username or password or both. Try again!");
                }

            } while (!loginSucceded);

            Console.WriteLine("\nLogin Succeded!");
            Console.ReadKey();
            return "";
        }
        
    }
}
