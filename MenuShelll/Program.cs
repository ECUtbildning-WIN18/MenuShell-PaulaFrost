using System;
using System.Data.SqlClient;
using MenuShell.Domain;
using MenuShell.Service;
using MenuShell.View;

namespace MenuShell
{
    class Program
    {
        static void Main(string[] args)
        {

            //var displayUsers = new SQLDisplayUser();

            //displayUsers.DisplayUsers();

            //var userLoader = new XMLUserLoader();
            var userLoader = new SQLLoader();

            //var authenticationService = new AuthenticationService(userLoader);

            var autheticateUsers = new SQLLogin();

            var loginView = new LoginView(autheticateUsers);

            var validUser = loginView.Display();

            //var users = userLoader.LoadUsers();
            var users = userLoader.UserLoaders();

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
            Console.ReadKey();
        } 
    }
}
