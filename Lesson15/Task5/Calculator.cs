using System;

namespace Lesson15
{
    public delegate double MathOperations(double a, double b);

    public static class Calculator
    {
        public static MathOperations Add = (a, b) =>  a + b;

        public static MathOperations Substract = (a, b) => a - b;

        public static MathOperations Multiply = (a, b) => a * b;

        public static MathOperations Divide = (a, b) => b == 0 ? throw new DivideByZeroException() : a / b;
    }
}
