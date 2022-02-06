using System;
using System.Threading;

namespace Lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            Thread firstThread = new Thread(new ParameterizedThreadStart(counter.ShowCounter));
            Thread secondThread = new Thread(new ParameterizedThreadStart(counter.ShowCounter));
            Thread thirdThread = new Thread(new ParameterizedThreadStart(counter.ShowCounter));

            firstThread.Start(1);
            secondThread.Start(2);
            thirdThread.Start(3);

            Console.ReadKey();
        } 
    }
}
