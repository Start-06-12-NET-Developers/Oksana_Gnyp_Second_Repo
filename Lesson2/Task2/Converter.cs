using System;

namespace Lesson2
{
    class Converter
    {
        private double usd;
        private double euro;
        private double rub;

        public UAH uan;

        public Converter(double usd = 0, double euro = 0, double rub = 0)
        {
            this.usd = usd;
            this.euro = euro;
            this.rub = rub;
            uan = new UAH();
        }

        public void ConvertToUAH()
        {
            Console.WriteLine("{0} USD = {1} UAH", usd, Math.Round((usd * 27.50), 2));
            Console.WriteLine("{0} EURO = {1} UAH", euro, Math.Round((euro * 31.16), 2));
            Console.WriteLine("{0} RUB {1} = UAH", rub, Math.Round((rub * 0.3), 2));
        }
    }
}
