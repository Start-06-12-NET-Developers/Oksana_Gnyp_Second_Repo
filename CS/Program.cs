using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 2

            Console.WriteLine("Enter first side");
            double firstSide = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second side");
            double secondSide = Convert.ToDouble(Console.ReadLine());

            double area = new Rectangle_Task2(firstSide, secondSide).Area;
            double perimeter = new Rectangle_Task2(firstSide, secondSide).Perimeter;

            Console.WriteLine("Area = {0}, and perimeter = {1}", Math.Round(area, 2), Math.Round(perimeter, 2));

            #endregion

            #region 3

            Book_Task3 book = new Book_Task3();
            book.AddText("Gueshe", "Vavilon", "Some Context");
            book.Show();

            #endregion

            #region 4

            Point point1 = new Point(2, 2);
            Point point2 = new Point(4, 2);
            Point point3 = new Point(4, 0);
            Point point4 = new Point(2, 0);
            Point point5 = new Point();

            Figure figure = new Figure(point1, point2, point3);
            figure.PerimeterCalculator();

            #endregion

            #region 5

            Address address = new Address(81400, "Ukraine", "Lviv", "Santa", "43a", "34");

            Console.WriteLine(address.Index);
            Console.WriteLine(address.Country);
            Console.WriteLine(address.City);
            Console.WriteLine(address.Street);
            Console.WriteLine(address.House);
            Console.WriteLine(address.Apartment);

            #endregion
            Console.ReadLine();
        }
    }
}
