using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Claims;
using MenuShell.Domain;
using MenuShell.Service;
using MenuShell.View;

namespace MenuShell
{
    class Program
    {
        static void Main(string[] args)
        {
            var systemAdministratorView = new SystemAdministratorView();

            var users = new Dictionary<string, User>
            {
                {"admin", new User(username: "admin", password: "secret", role: "Administrator") }
            };

            var loginView = new LoginView(users);

            var validUser = loginView.Display();

            if (validUser.Role == "Administrator")
            {
                
            }

            
            
            




            Console.WriteLine("Wazzup my Nagas!");
        }
    }
}
