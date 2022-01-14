using System;

namespace Lesson3
{
    public class Ship : Vehicle
    {
        public Ship(double price, int speed, int yearOfRelease) : base(price, speed, yearOfRelease)
        {

        }

        public override void PassQuantity()
        {
            int newShip = yearOfRelease + 5;

            if (DateTime.Now.Year <= newShip)
            {
                Console.WriteLine("4000 passengers allowed");
            }
            else
            {
                Console.WriteLine("2000 passengers allowed");
            }
        }

        public override void Port()
        {
            if (price <= 1300000)
            {
                Console.WriteLine("Postscript port - Odessa");
            }
            else
            {
                Console.WriteLine("Postscript port - Stambul");
            }
        }

        public override void GetVehicleInfo()
        {
            base.GetVehicleInfo();

            PassQuantity();
            Port();
            Console.WriteLine();
        }
    }
}
