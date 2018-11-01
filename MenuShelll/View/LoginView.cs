using MenuShell.Domain;
using System;
using System.Threading;
using MenuShell.Service;

namespace MenuShell.View
{
    public class LoginView
    {
        //private readonly IAuthenticationService _authenticationService;

        //public LoginView(IAuthenticationService authenticationService)
        //{
        //    _authenticationService = authenticationService;
        //}

        private readonly SQLLogin _sqlLogin;

        public LoginView(SQLLogin sqlLogin)
        {
            _sqlLogin = sqlLogin;
        }

        public User Display()
        {
            User validUser = null;

            do
            {
                Console.Clear();

                Console.WriteLine("Please log in\n");
                Console.WriteLine("Username:");
                Console.WriteLine("Password:");

                WriteAt(" ", 9, 2);
                string username = Console.ReadLine();
                WriteAt(" ", 9, 3);
                string password = Console.ReadLine();

                Console.WriteLine("\nIs this correct? (Y)es (N)o");
                var consoleKeyInfo = Console.ReadKey(true);

                if (consoleKeyInfo.Key == ConsoleKey.Y)
                {
                    validUser = _sqlLogin.AuthenticateUser(username, password);

                    if(validUser == null)
                    {
                        Console.Clear();
                        Console.WriteLine("Login failed, please try again!");
                        Thread.Sleep(2000);
                    }
                }
                else if (consoleKeyInfo.Key == ConsoleKey.N)
                {

                }

            } while (validUser == null);

            return validUser;
        }

        public static int xCoord, yCoord, y;

        static void WriteAt(string s, int x, int y)
        {
            Console.SetCursorPosition(xCoord + x, yCoord + y);
            Console.Write(s);
        }
    }
}
