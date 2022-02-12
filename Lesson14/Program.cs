using System;

namespace Lesson14
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task2

            MyLinkedList<string> dailyPlan = new MyLinkedList<string>();

            dailyPlan.AddFirst("Wake up");
            dailyPlan.AddLast("Go to bed");
            dailyPlan.AddBefore("Go to bed", "Clean teeth");
            dailyPlan.AddAfter("Wake up", "Make breakfest");

            Console.WriteLine(dailyPlan[1]);
            Console.WriteLine(dailyPlan.Count);

            new Action(dailyPlan.CustomForEach)?.Invoke();
            
            #endregion

            #region Task3

            MyDictionary<int, string> goods = new MyDictionary<int, string>();

            goods.Add(1, "Lipstick");
            goods.Add(2, "Shower");
            goods.Add(3, "Soap");

            Console.WriteLine(goods[0]);
            Console.WriteLine(goods.Count);

            foreach (string item in goods)
            {
                Console.WriteLine(goods.CurrentPair);
            }

            #endregion

            #region Task4

            TryQueue document = new TryQueue();

            document.AddDocument("First");
            document.AddDocument("second");
            document.AddDocument("third");

            TryQueue.GetArray(document);

            #endregion
            Console.ReadKey();
        }
    }
}
