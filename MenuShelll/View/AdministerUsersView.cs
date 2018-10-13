using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MenuShell.View
{
    class AdministerUsersView : ConsoleView
    {
        public override string Display()
        {
            Console.WriteLine("1. Add user");
            Console.WriteLine("2. Remove user");

            Console.WriteLine(">");

            Console.WriteLine("Esc to return to main view.");

            var consoleKeyInfo = Console.ReadKey(true);

            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.D1:
                    return "1";
                case ConsoleKey.D2:
                    return "2";
                default:
                    return "";
            }

            return "";
        }
    }
}
