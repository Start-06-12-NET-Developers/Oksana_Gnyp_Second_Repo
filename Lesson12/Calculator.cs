using System;

namespace Lesson12
{
    public delegate void MathOperations(double x, double y);

    public class Calculator
    {
        private double x;
        private double y;

        MathOperations action = null;

        public event MathOperations myEvent
        {
            add
            {
                action += value;
                Console.WriteLine($"Added {value.Method.Name}");
            }
            remove
            {
                action -= value;
                Console.WriteLine($"Removed {value.Method.Name}");
            }
        }

        public Calculator(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void InvokeMethod()
        {
            action?.Invoke(x, y);
        }
    }
}
