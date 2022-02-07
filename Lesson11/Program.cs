using System;
using System.Linq;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task2

            Car<string, int> tesla = new Car<string, int>("tesla", 2020);
            Car<string, int> porshe = new Car<string, int>("porshe", 2019);
            Car<string, int> bmw = new Car<string, int>("bmw", 2015);

            CarCollections<Car<string, int>> carsCollection = new CarCollections<Car<string, int>>();
            carsCollection.AddCars(tesla, porshe, bmw, new Car<string, int>("Audi", 2015));

            var IsTesla = carsCollection.Any(item => item.Model == "tesla");

            Console.WriteLine(carsCollection[0]);
            Console.WriteLine(IsTesla);

            #endregion

            #region Task3

            Dictionary dictionary = new Dictionary();
            dictionary.Add("Potato", "description for potato");
            dictionary.Add("Lemon", "description for lemon");

            Console.WriteLine(dictionary[1]);
            Console.WriteLine(dictionary.Count);

            #endregion
            Console.ReadLine();
        }
    }
}
