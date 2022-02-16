namespace Lesson17
{
    public delegate dynamic MathOperations(double a, double b);

    public static class Calculator
    {
        public static MathOperations Add = (a, b) => a + b;

        public static MathOperations Subtract = (a, b) => a - b;

        public static MathOperations Multiply = (a, b) => a * b;

        public static MathOperations Divide = (a, b) => b == 0 ? -1 : a / b;
    }
}
