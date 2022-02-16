namespace Lesson17
{
    public class Car 
    {
        private string model;
        private string color;
        private int releaseYear;

        public string Model => model;

        public string Color => color;

        public int ReleaseYear => releaseYear;

        public Car(string model, string color, int releaseYear)
        {
            this.model = model;
            this.color = color;
            this.releaseYear = releaseYear;
        }
    }
}
