using System;

namespace Lesson2
{
    public class UAH
    {
        public double ConvertToUSD(double uan)
        {
            return Math.Round((uan / 27.50), 2);
        }

        public double ConvertToEURO(double uan)
        {
            return Math.Round((uan / 31.16), 2);
        }

        public double ConvertToRUB(double uan)
        {
            return Math.Round((uan / 0.3), 2);
        }
    }
}
