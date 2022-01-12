using System;

namespace Lesson2
{
    public class User
    {
        private readonly string login;
        private readonly string name;
        private readonly string surname;
        private readonly int age;
        private readonly DateTime date;

        public User(string login, string name, string surname, int age, DateTime date)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.date = date;
        }

        public void GetUserInfo()
        {
            Console.WriteLine("Login: {0}", login);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Surname: {0}", surname);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Creation date: {0}", date.ToShortDateString());
        }
    }
}
