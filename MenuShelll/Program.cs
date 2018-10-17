using System;
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

            var users = userLoader.LoadUsers();

            if (validUser.Role == Role.Administrator)
            {
                var adminView = new SystemAdministratorView(users);

                adminView.Display();
            }
            else if (validUser.Role == Role.Receptionist)
            {
                var receptionistView = new ReceptionistMainMenuView(users);

                receptionistView.Display();
 
            }

            Console.WriteLine("Wazzup my Nagas!");
        }
    }
}
