using System;

namespace Lesson1
{
    public class Content_Task3
    {
        private string content;

        public Content_Task3(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.WriteLine("Content: {0}", content);
        }
    }
}
