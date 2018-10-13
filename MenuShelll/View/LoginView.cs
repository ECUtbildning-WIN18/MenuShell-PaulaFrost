using System;
using System.Collections.Generic;
using MenuShell.Service;

namespace MenuShell.View
{
    public class LoginView : ConsoleView
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

                var authenticationService = new AuthenticationService();

                var users = authenticationService.Authenticate(username, password);

                if (keyInfo.Key == ConsoleKey.Y)
                {
                    if (username == users.UserName && password == users.Password)
                    {
                        loginSucceded = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid username and/or password");
                    }
                }
                else if(keyInfo.Key == ConsoleKey.N)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }

            } while (!loginSucceded);
            Console.WriteLine("\nLogin Succeded!");
            Console.ReadKey();
            return "";
        }
        
    }
}
