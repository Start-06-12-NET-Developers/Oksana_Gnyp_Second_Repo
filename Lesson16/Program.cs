using System;

namespace Lesson16
{
    class Program 
    {
        static void Main(string[] args)
        {
            #region Task2

            Block firstBlock = new Block(10, 12);
            Console.WriteLine(firstBlock.Equals(new Block(10, 12)));

            #endregion

            #region Task3

            House house1 = new House(4, "PentHause");
            House house2 = (House)house1.Clone();
            house2.RoomQuantity = 3;

            Console.WriteLine(house1);
            Console.WriteLine(house2);

            House house3 = house1.DeepCopy(house1);
            house3.RoomQuantity = 5;

            Console.WriteLine(house1);
            Console.WriteLine(house3);
            Console.WriteLine(house1 + house2);

            #endregion
            Console.ReadKey();
        }
    }
}
