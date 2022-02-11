using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson14
{
    public class MyLinkedList<T>
    {
        public LinkedList<string> plansForDay = new LinkedList<string>();

        public int Count => plansForDay.Count;

        public string this[int value] => plansForDay.ElementAt(value);

        public void AddFirst(string item)
        {
            plansForDay.AddFirst(item);
        }

        public void AddLast(string item)
        {
            plansForDay.AddLast(item);
        }

        public void AddBefore(string before, string item)
        {
            LinkedListNode<string> beforeItem = plansForDay.Find(before);
            plansForDay.AddBefore(beforeItem, item);
        }

        public void AddAfter(string after, string item)
        {
            LinkedListNode<string> afterItem = plansForDay.Find(after);
            plansForDay.AddAfter(afterItem, item);
        }

        public void CustomForEach()
        {
            for (LinkedListNode<string> i = plansForDay.First; i != null; i = i.Next)
            {
                Console.WriteLine(i.Value);
            }
        }
    }
}
