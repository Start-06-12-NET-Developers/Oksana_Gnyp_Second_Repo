using System;

namespace Lesson8
{
    public class CalculateDays
    {
        public static void CalcDaysToBirthday(DateTime birthDay)
        {
            TimeSpan daysToBirthDay;

            if (birthDay.Month > DateTime.Now.Month) 
            {
                DateTime birthDayThisYear = new DateTime(DateTime.Now.Year, birthDay.Month, birthDay.Day);
                daysToBirthDay = birthDayThisYear - DateTime.Now.Date;
            }
            else if (birthDay.Month == DateTime.Now.Month && birthDay.Day > DateTime.Now.Day)
            {
                DateTime birthDayThisYear = new DateTime(DateTime.Now.Year, birthDay.Month, birthDay.Day);
                daysToBirthDay = birthDayThisYear - DateTime.Now.Date;
            }
            else 
            {
                DateTime birthDayNextYear = new DateTime(DateTime.Now.Year+1, birthDay.Month, birthDay.Day);
                daysToBirthDay = birthDayNextYear - DateTime.Now.Date;
            }

            Console.WriteLine($"{daysToBirthDay.Days} day(s) left to the next birthday");
        }
    }
}
