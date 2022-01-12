using System;

namespace Lesson1
{
    public class Book_Task3
    {
        private Title_Task3 title;
        private Author_Task3 author;
        private Content_Task3 content;

        public void AddText(string bookAuthor, string bookTitle, string bookContent)
        {
            title = new Title_Task3(bookTitle);
            content = new Content_Task3(bookContent);
            author = new Author_Task3(bookAuthor);
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            author.Show();
            Console.ForegroundColor = ConsoleColor.Red;
            title.Show();
            Console.ForegroundColor = ConsoleColor.Blue;
            content.Show();
            Console.ResetColor();
        }
    }
}
