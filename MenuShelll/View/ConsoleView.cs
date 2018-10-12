using System;

namespace MenuShell.View
{
    class ConsoleView
    {
        public virtual string Display()
        {
            Console.Clear();

            return "";
        }
    }
}
