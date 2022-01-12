using System;

namespace Lesson2
{
    public class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;

        private string article;
        private int quantity;

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void TotalPrice(int quantity)
        {
            var price = quantity * 250;

            Console.WriteLine("Price with tax: {0}", price + (price * 0.05));
            Console.WriteLine("Price without tax: {0}", price);
        }
    }
}
