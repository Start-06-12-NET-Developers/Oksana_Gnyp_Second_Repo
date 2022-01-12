using System;

namespace Lesson1
{
    public class Title_Task3
    {
        private string title;

        public Title_Task3(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.WriteLine("Title: {0}", title);
        }
    }
}
