using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lesson14
{
    public class MyDictionary<T, K> : IEnumerable<K>, IEnumerator<K>
                                      where T : struct
                                      where K : class
    {
        int index = -1;

        private Dictionary<T, K> dictionary;

        public MyDictionary()
        {
            dictionary = new Dictionary<T, K>();
        }

        public string this[int index] => dictionary.ElementAt(index).Key.ToString() + " - " + dictionary.ElementAt(index).Value;

        public int Count => dictionary.Count;

        public K Current => dictionary.ElementAt(index).Value;

        public KeyValuePair<T, K> CurrentPair => dictionary.ElementAt(index);

        object IEnumerator.Current => dictionary.Values.ElementAt(index);

        public void Add(T key, K value)
        {
            dictionary.Add(key, value);
        }

        public void Dispose()
        {
            
        }

        public IEnumerator<K> GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (index < dictionary.Count - 1)
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        IEnumerator<K> IEnumerable<K>.GetEnumerator()
        {
            return this;
        }
    }
}
