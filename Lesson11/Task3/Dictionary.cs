using System.Collections.Generic;
using System.Linq;

namespace Lesson11
{
    public class Dictionary
    {
        private Dictionary<string, string> myDictionary;

        public Dictionary()
        {
            myDictionary = new Dictionary<string, string>();
        }

        public string this[int index] => myDictionary.ElementAt(index).Key + " - " + myDictionary.ElementAt(index).Value;

        public int Count => myDictionary.Count;

        public void Add(string key, string value)
        {
            myDictionary.Add(key, value);
        }
    }
}
