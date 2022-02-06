using System;
using System.Threading;

namespace Lesson13
{
    public class Counter
    {
        Object block = new Object();
       
        public void ShowCounter(object counter)
        {
            int count = (int)counter;

            lock (block)
            {
                Console.WriteLine("ShowCounter start");

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(count);
                    Thread.Sleep(1000);
                    count++;
                }

                Console.WriteLine("ShowCounter stop");
            }
        }
    }
}
