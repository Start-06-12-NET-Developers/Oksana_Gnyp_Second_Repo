using System;

namespace Lesson8
{
    public static class ColorPrinter
    {
        public static void Print(string text, CustomColor color)
        {
            switch (color)
            {
                case CustomColor.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(text);
                    Console.ResetColor();
                    break;
                case CustomColor.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(text);
                    Console.ResetColor();
                    break;
                case CustomColor.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(text);
                    Console.ResetColor();
                    break;
                case CustomColor.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(text);
                    Console.ResetColor();
                    break;
            }
        }
    }
}
