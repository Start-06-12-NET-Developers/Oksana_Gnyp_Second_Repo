using System;

namespace Lesson6
{
    public class Book
    {
        private static string content;
        public class Notes
        {
            public void Save(params string[] array)
            {
                foreach (string item in array)
                {
                    content += item + " ";
                }

                Console.WriteLine(content);
            }
        }
    }
}
