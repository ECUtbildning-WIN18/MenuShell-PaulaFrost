using System;

namespace MenuShell.View
{
    abstract class BaseView
    {
        public string Title { get; set; }

        public BaseView(string title)
        {
            Title = title;

            Console.Title = title;
        }
    }
}
