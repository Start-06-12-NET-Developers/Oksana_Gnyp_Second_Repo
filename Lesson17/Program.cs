using System;
using System.Linq;
using System.Collections.Generic;

namespace Lesson17
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            #region Task2

            List<Car> cars = new List<Car>()
            {
                new Car("Toyota", "black", 2012),
                new Car("Pezho", "white", 2019),
                new Car("Opel", "green", 2020)
            };

            List<Customer> customers = new List<Customer>()
            {
                new Customer("Bohdan", 0975667345, "Toyota"),
                new Customer("Iryna", 0985645321, "Opel"),
                new Customer("Inna", 08745678, "Ferrari")
            };

            var carInfo = from customer in customers join car in cars 
                          on customer.Model equals car.Model
                          where customer.Name == "Bohdan" 
                          select new
                                 {
                                     Name = customer.Name,
                                     Phone = customer.PhoneNumber,
                                     CarModel = customer.Model,
                                     CarColor = car.Color,
                                     ReleaseYear = car.ReleaseYear
                                 };

            foreach (var item in carInfo)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Task5;

            dynamic a =3;
            dynamic b = 6;

            Console.WriteLine(Calculator.Add(3, 5));

            #endregion

            #region Task3

            dynamic vocabulary = new
            {
                words = new Dictionary<string, string>()
                {
                    {"Apple", "Яблуко" },
                    {"Potato", "Картопля" },
                    {"Cherry", "Вишня" },
                    {"Tomato", "Помідор" },
                    {"Banana", "Банан"},
                    {"Pineapple", "Ананас" },
                    {"Plumb", "Слива" },
                    {"Carrot", "Морква" },
                    {"Strawbery", "Полуниця"},
                    {"Lemon", "Лимон"}

                },
            };

            foreach (KeyValuePair<string, string> item in vocabulary.words)
            {
                Console.WriteLine(item);
            }

            #endregion
            Console.ReadKey();
        }
    }
}
