using System;
using System.Linq;

namespace Lesson15
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task2

            Worker[] workers = new Worker[5];
            fullfilWorkerInfo(2015, workers);

            #endregion

            #region Task5

            Console.WriteLine("Enter first operand");
            double firtsNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second operand");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter math operation: +, -, *, /");
            string sign = Console.ReadLine();

            MathOperations(sign, firtsNumber, secondNumber);

            #endregion

            Console.ReadKey();
        }

        static void fullfilWorkerInfo(int yearOfEmployment, Worker[] workers)
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("worker name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("worker position: ");
                    string position = Console.ReadLine();
                    Console.WriteLine("year of employment:");
                    int year = Convert.ToInt32(Console.ReadLine());

                    if(year > DateTime.Now.Year)
                    {
                        throw new ArgumentException();
                    }

                    workers[i] = new Worker(name, position, year);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                var sortedList = from item in workers
                                 orderby item.YearOfEmployment
                                 select item;

                foreach (Worker item in sortedList)
                {
                    if (item.YearOfEmployment !=0 && item.YearOfEmployment <= yearOfEmployment)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
            }
        }

        static void MathOperations(string sign, double first, double second)
        {
            switch (sign)
            {
                case "+":
                    Console.WriteLine(Calculator.Add(first, second));
                    break;
                case "-":
                    Console.WriteLine(Calculator.Substract(first, second));
                    break;
                case "*":
                    Console.WriteLine(Calculator.Multiply(first, second))   ;
                    break;
                case "/":
                    Console.WriteLine(Calculator.Divide(first, second)) 
                        ;
                    break;
                default:
                    Console.WriteLine("No such math operation!");
                    break;
            }
        }
    }
}
