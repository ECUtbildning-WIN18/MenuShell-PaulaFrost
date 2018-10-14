using System;
using System.Collections.Generic;
using MenuShell.Domain;
using MenuShell.Service;
using MenuShell.View;

namespace MenuShell
{
    class Program
    {
        static void Main(string[] args)
        {
            var userLoader = new XMLUserLoader();

            var authenticationService = new AuthenticationService(userLoader);

            var loginView = new LoginView(authenticationService);

            var validUser = loginView.Display();

            if (validUser.Role == Role.Administrator)
            {
                var adminView = new SystemAdministratorView(); //??
                adminView.Display();
            }

            Console.WriteLine("Wazzup my Nagas!");
        }
    }
}
