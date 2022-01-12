using System;

namespace Lesson1
{
    public class Author_Task3
    {
        private string author;

        public Author_Task3(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.WriteLine("Author: {0}", author);
        }
    }
}
