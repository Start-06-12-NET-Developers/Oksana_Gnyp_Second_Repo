using System;

namespace Lesson3
{
    public class Vehicle
    {
        internal double price;
        internal int speed;
        internal int yearOfRelease;

        public Vehicle(double price, int speed, int yearOfRelease)
        {
            this.price = price;
            this.speed = speed;
            this.yearOfRelease = yearOfRelease;
        }

        public virtual void Height()
        {
            
        }

        public virtual void PassQuantity()
        {
           
        }

        public virtual void Port()
        {
            
        }

        public virtual void GetVehicleInfo()
        {
            Console.WriteLine("Price: {0}", price);
            Console.WriteLine("Speed: {0}", speed);
            Console.WriteLine("Year of release: {0}", yearOfRelease);
        }
    }
}
