using System;
using MenuShell.Domain;
using MenuShell.EntityFramework;
using MenuShell.Service;
using MenuShell.View;

namespace MenuShell
{
    class Program
    {
        static void Main(string[] args)
        {
            var loginView = new LoginView();
            
            var validUser = loginView.Display();

            if (validUser.Role == Role.Administrator)
            {
                var adminView = new SystemAdministratorView();

                adminView.Display();
            }
            else if (validUser.Role == Role.Receptionist)
            {
                var receptionistView = new ReceptionistMainMenuView();

                receptionistView.Display();
            }

            Console.WriteLine("Wazzup my Nagas!");
            Console.ReadKey();
        } 
    }
}
