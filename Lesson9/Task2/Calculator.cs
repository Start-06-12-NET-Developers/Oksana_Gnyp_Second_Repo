using System;

namespace Lesson9
{
    public delegate double MathOperations(double x, double y);

    public class Calculator
    {
        public static MathOperations Add = new MathOperations((x, y) => x + y);

        public static MathOperations Sub = new MathOperations((x, y) => x - y);

        public static MathOperations Mul = new MathOperations((x, y) => x * y);

        public static MathOperations Div = new MathOperations((x, y) =>
                                                              {
                                                                 if (y != 0)
                                                                 {
                                                                    return x / y;
                                                                 }
                                                                 else
                                                                 { 
                                                                    Console.WriteLine("You cannot divide by zero! The action " +
                                                                                      "is rejected!");
                                                                     return x;
                                                                 }
                                                               });
    }
}
