using System;

namespace Lesson7
{
    public struct Notebook
    {
        private string brand;
        private string producer;
        private double price;

        public Notebook(string brand, string producer, double price)
        {
            this.brand = brand;
            this.producer = producer;
            this.price = price;
        }

        public void NotebookInfo()
        {
            Console.WriteLine($"Brand: {brand}, Producer: {producer}, Price: {price}");
        }
    }
}
