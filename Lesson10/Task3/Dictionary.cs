using System.Collections.Generic;

namespace Lesson10
{
    public class Dictionary
    {
        private Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public string this[int index]
        {
            get
            {
                int counter = 0;

                foreach (string item in dictionary.Keys)
                {
                    if (counter == index)
                    {
                        return $"{item} - {dictionary[item]}";
                    }

                    counter++;
                }

                return "No such word!";
            }
        }

        public int Counter => dictionary.Count;

        public void Add(string ukr, string eng)
        {
            dictionary.Add(ukr, eng);
        }
    }
}
