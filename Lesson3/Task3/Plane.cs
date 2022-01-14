using System;

namespace Lesson3
{
    public class Plane : Vehicle
    {
        public Plane(double price, int speed, int yearOfRelease) : base(price, speed, yearOfRelease)
        {

        }    
        
        public override void Height()
        {
            if (speed <= 460)
            {
                Console.WriteLine("Height of the plane = 12 000");
            }
            else
            {
                Console.WriteLine("Heigh of the plane = 9 000");
            }
        }

        public override void PassQuantity()
        {
            int newPlain = yearOfRelease + 3;

            if (DateTime.Now.Year <= newPlain)
            {
                Console.WriteLine("100 passengers allowed");
            }
            else
            {
                Console.WriteLine("50 passengers allowed");
            }
        }

        public override void GetVehicleInfo()
        {
            base.GetVehicleInfo();

            Height();
            PassQuantity();
            Console.WriteLine();
        }
    }
}
