namespace Lesson1
{
    public class Point
    {
        private int point1;
        private int point2;
        private string name;

        public int Point1
        {
            get
            {
                return point1;
            }
        }

        public int Point2
        {
            get
            {
                return point2;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public Point(int firstPoint = 0, int secondPoint = 0, string text = "")
        {
            point1 = firstPoint;
            point2 = secondPoint;
            name = text;
        }
    }
}
