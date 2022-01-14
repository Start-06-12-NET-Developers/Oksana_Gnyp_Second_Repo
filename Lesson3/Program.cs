using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task2

            ClassRoom classRoom = new ClassRoom(new ExelentPupil("Iryna"), new GoodPupil("Ihor"),
                                                new GoodPupil("Dmytro"));

            classRoom.PupilsInfo();

            #endregion

            #region Task3

            Vehicle ship = new Ship(30000, 450, 2019);
            Vehicle plane = new Plane(30000, 900, 2017);
            Vehicle car = new Car(20000, 90, 2018);

            ship.GetVehicleInfo();
            plane.GetVehicleInfo();
            car.GetVehicleInfo();

            #endregion

            #region task5

            Printer printer = new Printer();
            printer.Print("Red color text", new Red());

            #endregion
            Console.ReadKey();
        }
    }
}
