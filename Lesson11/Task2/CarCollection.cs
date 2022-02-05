using System.Collections;
using System.Collections.Generic;

namespace Lesson11
{
    public class CarCollections<T> : IEnumerable<T>, IEnumerator<T> where T : Car<string, int>
    {
        int index = -1;

        private static List<T> cars = new List<T>();

        public string this[int index] => ToString();
        
        public int CarsCount => cars.Count;

        T IEnumerator<T>.Current => cars[index];
      
        object IEnumerator.Current => cars[index];

        public void AddCars(params T[] car)
        {
            cars.AddRange(car);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if (index < cars.Count - 1)
            {
                index++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            index = -1;
        }

        public void Clear()
        {
            cars = new List<T>();
        }

        public override string ToString()
        {
            return cars[index].Model + "," + cars[index].Number;
        }
    }
}
