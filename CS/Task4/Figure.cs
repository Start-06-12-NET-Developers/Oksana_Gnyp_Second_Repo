using System;

namespace Lesson1
{
    public class Figure
    {
        private Point[] points = new Point[6];
        public Figure(Point first, Point second, Point third)
        {
            points[0] = first;
            points[1] = second;
            points[2] = new Point(third.Point1, third.Point2, "Tringle");
        }

        public Figure(Point first, Point second, Point third, Point fourth): this(first, second, third)
        {
            points[3] = new Point(fourth.Point1, fourth.Point2, "Rectangle");
        }

        public Figure(Point first, Point second, Point third, Point fourth, Point fifth): this(first,
                                                                                               second,
                                                                                               third,
                                                                                               fourth)
        {
            points[4] = new Point(fifth.Point1, fifth.Point2, "Pentagon");
        }

        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((b.Point1 - a.Point1), 2) + Math.Pow((b.Point2 - a.Point2), 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;
            
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i + 1] != null)
                {
                    perimeter += LengthSide(points[i], points[i+1]);
                    continue;
                }

                Console.WriteLine("Perimeter of {0} = {1}", points[i].Name, Math.Round(perimeter += LengthSide(points[i], points[0]), 2));
                break;
            }
        }
    }
}
