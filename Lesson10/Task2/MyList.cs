using System.Collections;
using System.Collections.Generic;

namespace Lesson10
{
    public class MyList : IEnumerable, IEnumerator
    {
        private List<string> myToDoList = new List<string>();
        int index = -1;

        public List<string> MyToDoList
        {
            get
            {
                return myToDoList;
            }
        }

        public string this[int index]
        {
            get
            {
                int counter = 0;

                foreach (string item in myToDoList)
                {
                    if (counter == index)
                    {
                        return item;
                    }

                    counter++;
                }

                return "No element found";
            }
        }

        public int MyListCount => myToDoList.Count;

        public object Current => myToDoList[index];

        public void AddElement(string task)
        {
            myToDoList.Add(task);
        }

        public void AddElements(params string[] tasks)
        {
            myToDoList.AddRange(tasks);
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (index < myToDoList.Count - 1)
            {
                index++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
