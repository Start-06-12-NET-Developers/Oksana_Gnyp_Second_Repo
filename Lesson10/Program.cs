using System;
using System.Linq;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task2

            MyList myList = new MyList();
            myList.AddElement("First task");
            myList.AddElements("Second", "Third", "Last");

            Console.WriteLine(myList.MyListCount);
            Console.WriteLine(myList[1]);

            #endregion

            #region Task4

            Task4.ShowListOfTasks<string>(myList);

            var third = myList.MyToDoList.FirstOrDefault(task => task == "Third");
            Console.WriteLine(third);

            #endregion

            #region Task5

            var list2 = MyClass.FactoryMethod<MyList>(new MyList());
            Console.WriteLine(list2.GetType().Name);

            #endregion

            #region Task3

            Dictionary myDictionary = new Dictionary();
            myDictionary.Add("Яблуко", "Apple");
            myDictionary.Add("Апельсин", "Orange");
            Console.WriteLine(myDictionary[1]);
            Console.WriteLine(myDictionary.Counter);

            #endregion

            Console.ReadKey();
        }
    }
}
