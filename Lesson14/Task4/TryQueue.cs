using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lesson14
{
    public class TryQueue : IEnumerable, IEnumerator
    {
        int index = -1;

        Queue<string> documents;

        public TryQueue()
        {
            documents = new Queue<string>();
        }

        public object Current => documents.ElementAt(index);

        public string this[int index] => (string)Current;
       
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (index < documents.Count - 1)
            {
                index++;
                return true;
            }

            Reset();
            return false;
        }

        public void Reset()
        {
            index = -1;
        }

        public void AddDocument(string documentName)
        {
            documents.Enqueue(documentName);
        }

        public static IEnumerable GetArray(IEnumerable list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            return list;
        }
    }
}
