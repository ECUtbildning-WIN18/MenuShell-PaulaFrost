using System;

namespace MenuShell.View
{
    public class ConsoleView
    {
        public virtual string Display()
        {
            Console.Clear();

            return "";
        }
    }
}
