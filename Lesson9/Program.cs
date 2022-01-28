using System;

namespace Lesson9
{
    public delegate double Median(int first, int second, int third);

    public delegate int CountMedian(params SomeIntDelegate[] delegatesArray);

    public delegate int SomeIntDelegate();
    
    class Program
    {
        static void Main(string[] args)
        {
            #region Task2

            Console.WriteLine("Enter firts operand:");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second operand:");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter one of math operations: +, -, *, /");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    var AdditionResult = Calculator.Add(firstNumber, secondNumber);
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {AdditionResult}");
                    break;
                case "-":
                    var SubstractionResult = Calculator.Sub(firstNumber, secondNumber);
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {SubstractionResult}");
                    break;
                case "*":
                    var MultiplicationResult = Calculator.Mul(firstNumber, secondNumber);
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {MultiplicationResult}");
                    break;
                case "/":
                    var DivisionResult = Calculator.Div(firstNumber, secondNumber);
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {DivisionResult}");
                    break;
                default:
                    Console.WriteLine("Math operator is not correct!");
                    break;
            }

            #endregion

            #region Task5

            Console.WriteLine(GetMedian(34, 50, 40));

            #endregion

            #region Task3

            Random random = new Random();
            SomeIntDelegate firstRandomNumber = new SomeIntDelegate(delegate () { return random.Next(5, 20); });
            SomeIntDelegate secondRandom = GetRandomNumber;

            CountMedian countMedian = new CountMedian((x)=> 
                                                          {
                                                             int? sum = 0;

                                                             foreach (SomeIntDelegate item in x)
                                                             {
                                                                sum += item?.Invoke();
                                                             }

                                                             return (int)(object)sum/x.Length;

                                                             });

            Console.WriteLine(countMedian(firstRandomNumber,secondRandom));

            #endregion

            Console.ReadKey();
        }

        static Median GetMedian = new Median((a, b, c) => (a + b + c) / 3);

        static int GetRandomNumber()
        {
            Random random = new Random();

            return random.Next(30, 40);
        }
    }
}
