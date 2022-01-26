using System;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task2

            Console.WriteLine("Enter text to print");
            string text = Console.ReadLine();
            Console.WriteLine("Enter one of text colors:\nred,\ngreen,\nyellow,\nwhite");
            string textColor = Console.ReadLine();

            switch (textColor.ToLower())
            {
                case "red":
                    ColorPrinter.Print(text, CustomColor.Red);
                    break;
                case "green":
                    ColorPrinter.Print(text, CustomColor.Green);
                    break;
                case "yellow":
                    ColorPrinter.Print(text, CustomColor.Yellow);
                    break;
                case "white":
                    ColorPrinter.Print(text, CustomColor.White);
                    break;
                default:
                    Console.WriteLine("Chosen color is not available!");
                    break;
            }

            #endregion

            #region Task3

            CheckBonus("Denys", Account.AskForBonus(Post.junior, 110));
            CheckBonus("Oleh", Account.AskForBonus(Post.middle, 180));

            #endregion

            #region Task5

            Console.WriteLine("Enter year of birth:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month of birth:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter day of birth:");
            int day = Convert.ToInt32(Console.ReadLine());

            CalculateDays.CalcDaysToBirthday(new DateTime(year, month, day));

            #endregion
            Console.ReadKey();
        }

        static void CheckBonus(string name, bool bonus)
        {
            if (bonus)
            {
                Console.WriteLine($"{name} will have monthly bonus");
            }
            else
            {
                Console.WriteLine($"{name} will not have additional pay this month");
            }
        }
    }
}
