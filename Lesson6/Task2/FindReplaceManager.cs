using System;
using System.Linq;

namespace Lesson6
{
    public static class FindReplaceManager
    {
        public static void FindNext(string value, string[] str)
        {
            if (str.Contains(value))
            {
                Console.WriteLine(value);
            }
        }
    }
}
