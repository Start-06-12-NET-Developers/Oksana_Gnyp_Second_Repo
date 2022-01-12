namespace Lesson1
{
    public class Rectangle_Task2
    {
        private double firstSide;
        private double secondSide;

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimeter 
        {
            get
            {
                return PerimeterCalulator();
            }
        }

        public Rectangle_Task2(double first, double second)
        {
            firstSide = first;
            secondSide = second;
        }

        public double AreaCalculator() 
        {
            return firstSide * secondSide;
        }

        public double PerimeterCalulator()
        {
            return 2 * (firstSide + secondSide);
        }
    }
}
