using System;
using MenuShell.Domain;
using MenuShell.View;

namespace MenuShell
{
    class Program
    {
        static void Main(string[] args)
        {
            var loginView = new LoginView();

            var authUser = loginView.Display();

            if (authUser.Role == Role.Administrator)
            {
                Console.WriteLine("admin menu");
            }

            Console.WriteLine("Wazzup my Nagas!");
        }
    }
}
