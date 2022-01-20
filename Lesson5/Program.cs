using System;
using System.Linq;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task2

            int[] testNumbers = new int[] { 20, 30, 15, 16, 10, 18, 2, 8, 32, 1 };
            int maxValue = testNumbers[0];
            int minValue = testNumbers[0];
            double median = Convert.ToDouble(GetArrayValues(testNumbers, ref maxValue, ref minValue)) / testNumbers.Length;

            Console.WriteLine("Overal sum: {0}", GetArrayValues(testNumbers, ref maxValue, ref minValue));
            Console.WriteLine("Maximum value: {0}", maxValue);
            Console.WriteLine("Minimum value: {0}", minValue);
            Console.WriteLine("Median: {0}", median);
            ShowOddNumbers(testNumbers);
            Console.WriteLine();

            var oddNumbers = testNumbers.Where(item => item % 2 != 0);
            Console.WriteLine("Min value = {0}", testNumbers.Min());
            Console.WriteLine("Max value = {0}", testNumbers.Max());
            Console.WriteLine("Median value = {0}", testNumbers.Average());
            Console.WriteLine("Sum of numbers = {0}", testNumbers.Sum());

            foreach (var item in oddNumbers)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Task3

            MyMatrix matrix = new MyMatrix(5, 4);

            #endregion

            #region Task4

            Article[] articles = new Article[]
            {
                new Article("firstItem", "Stock", 45),
                new Article("secondIem", "Stock", 32.6),
                new Article("thirdIem", "Stock", 10),
                new Article("fourthItem", "Retail", 100),
                new Article("fifth", "Retail", 50)
            };

            Store store = new Store(articles);
            Console.WriteLine(store[1]);
            Console.WriteLine(store["fifth"]);
            Console.WriteLine(store["seven"]);

            #endregion
            Console.ReadKey();
        }

        static int GetArrayValues(int[] numbersArray, ref int maxValue, ref int minValue)
        {
            int overalSum = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] > maxValue)
                {
                    maxValue = numbersArray[i];
                }

                if (numbersArray[i] < minValue)
                {
                    minValue = numbersArray[i];
                }

                overalSum += numbersArray[i];
            }

            return overalSum;
        }

        static void ShowOddNumbers(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.Write(array[i] + ", ");
                }
            }
        }
    }
}
