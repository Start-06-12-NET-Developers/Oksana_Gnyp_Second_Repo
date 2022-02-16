namespace Lesson17
{
    public class Customer
    {
        private string model;
        private string name;
        private int phoneNumber;

        public string Name => name;

        public int PhoneNumber => phoneNumber;

        public string Model => model;

        public Customer(string name, int phoneNumber, string  carModel)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            model = carModel;
        }
    }
}
