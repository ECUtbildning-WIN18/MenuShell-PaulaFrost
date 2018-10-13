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
            var loginView = new LoginView();
            var loadUser = new UserLoader();

            var users = new List<User>
            {
                new User(username: "admin", password: "secret", role: "Administrator")
            };

            loginView.Display();
            loadUser.LoadUsers();




            Console.WriteLine("Wazzup my Nagas!");
        }
    }
}
