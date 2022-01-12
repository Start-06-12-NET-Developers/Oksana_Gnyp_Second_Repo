using System;

namespace Lesson2
{
    public class Employee
    {
        private string name;
        private string surname;
        private double salary = 500;
        
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        private double CountSalary(int workingYears, string position, out double tax)
        {
            
            if (workingYears > 5)
            {
                salary *= salary;
            }

            if (position == "Senior")
            {
                salary += 2000;
            }

            tax = salary * 0.05;
            salary -= tax;
            return salary;
        }

        public void GetEmployeeInfo(int workingYears, string position, out double tax)
        {
            CountSalary(workingYears, position, out tax);

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Surname: {0}", surname);
            Console.WriteLine("Position: {0}", position);
            Console.WriteLine("Salary: {0}", salary);
            Console.WriteLine("Tax: {0}", tax);
        }
    }
}
