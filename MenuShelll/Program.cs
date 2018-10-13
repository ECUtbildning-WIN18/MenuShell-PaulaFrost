using System;
using MenuShell.View;

namespace MenuShell
{
    class Program
    {
        static void Main(string[] args)
        {
            var loginView = new LoginView();

            loginView.Display();




            Console.WriteLine("Wazzup my Nagas!");
        }
    }
}
