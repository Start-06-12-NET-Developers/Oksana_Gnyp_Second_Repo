using System;

namespace Lesson3
{
    public class Printer
    {
        public void Print(string value, Printer color)
        {
            if (color is Red)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(value);
                Console.ResetColor();
            }
            else if(color is Green)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("value");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("value");
                Console.ResetColor();
            }
        }
    }
}
