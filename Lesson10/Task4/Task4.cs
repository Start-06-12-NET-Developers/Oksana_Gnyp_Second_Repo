using System;

namespace Lesson10
{
    public static class Task4
    {
        public static void ShowListOfTasks<T>(this MyList list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
