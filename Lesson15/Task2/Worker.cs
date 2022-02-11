namespace Lesson15
{
    public struct Worker 
    {
        private string name;
        private string position;
        private int yearOfEmployment;

        public string Name => name;

        public string Position => position;

        public int YearOfEmployment => yearOfEmployment;

        public Worker(string name, string position, int yearOfEmployment)
        {
            this.name = name;
            this.position = position;
            this.yearOfEmployment = yearOfEmployment;
        }
    }
}
