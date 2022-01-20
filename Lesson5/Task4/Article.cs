namespace Lesson5
{
    public class Article
    {
        private string goodName;
        private string storeName;
        private double price;

        public string GoodName
        {
            get
            {
                return goodName;
            }
        }

        public Article(string goodName, string storeName, double price)
        {
            this.goodName = goodName;
            this.storeName = storeName;
            this.price = price;
        }

        public override string ToString()
        {
            return $"Name: {goodName}, Store: {storeName}, Price: {price}";
        }
    }
}
