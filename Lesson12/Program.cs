using System;

namespace Lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first operand");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second operand");
            double secondnumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter math operation: +, -, *, /");
            string sign = Console.ReadLine();

            Calculation(sign, new Calculator(firstNumber, secondnumber));
            Console.ReadKey();
        }

        static void Calculation(string sign, Calculator calculator)
        {
            switch (sign)
            {
                case "+":
                    calculator.myEvent += Add;
                    calculator.InvokeMethod();
                    calculator.myEvent -= Add;
                    break;
                case "-":
                    calculator.myEvent += Substract;
                    calculator.InvokeMethod();
                    calculator.myEvent -= Substract;
                    break;
                case "*":
                    calculator.myEvent += Multiply;
                    calculator.InvokeMethod();
                    calculator.myEvent -= Multiply;
                    break;
                case "/":
                    calculator.myEvent += Divide;
                    calculator.InvokeMethod();
                    calculator.myEvent -= Divide;
                    break;
            }
        }

        static void Add(double x, double y) => Console.WriteLine("{0} + {1} = {2}", x, y, x + y);

        static void Substract(double x, double y) => Console.WriteLine("{0} - {1} = {2}", x, y, x - y);

        static void Multiply(double x, double y) => Console.WriteLine("{0} * {1} = {2}", x, y, x * y);

        static void Divide(double x, double y)
        {
            if (y != 0)
            {
                Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            }
            else
            {
                Console.WriteLine("You cannot divide by zero!");
            }
        }
    }
}
