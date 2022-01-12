using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 2

            Converter convert = new Converter(10, 10, 10);
            convert.ConvertToUAH();

            var hrn = convert.uan.ConvertToEURO(270);
            Console.WriteLine("{0} UAH = {1} EURO", 270, hrn);

            #endregion

            #region Task 3

            Employee employee = new Employee("Iryna", "Dilon");
            employee.GetEmployeeInfo(6, "Senior", out double tax);

            #endregion

            #region Task 4

            Invoice olena = new Invoice(21153, "Olena", "lanNet");
            olena.TotalPrice(5);

            #endregion

            #region Task 6

            User user = new User("atma", "Anna", "Zuban", 19, DateTime.Today);
            user.GetUserInfo();

            #endregion

            Console.ReadKey();
        }
    }
}
