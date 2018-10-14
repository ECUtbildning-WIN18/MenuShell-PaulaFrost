using MenuShell.Domain;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MenuShell.View
{
    public class LoginView //: BaseView
    {
        //public LoginView() : base("Login")
        //{

        //}

        public User Display()
        {
            
             var users = new Dictionary<string, User>
             {
                  {"admin", new User(username: "admin", password: "secret", role: Role.Administrator)}
             };

            User authUser = null;

            do
            {
                Console.Clear();

                Console.WriteLine("Please log in\n");
                Console.WriteLine("Username:");
                Console.WriteLine("Password:");

                string username = Console.ReadLine();
                string password = Console.ReadLine();

                Console.WriteLine("\nIs this correct? (Y)es (N)o");
                var keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Y)
                {
                    if (users.ContainsKey(username) && users[username].Password == password)
                    {
                        authUser = users[username];
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Login failed, please try again!");
                        Thread.Sleep(2000);
                    }
                }
                else if (keyInfo.Key == ConsoleKey.N)
                {

                }

            } while (authUser == null);

            return authUser;
        } 
    }
}
