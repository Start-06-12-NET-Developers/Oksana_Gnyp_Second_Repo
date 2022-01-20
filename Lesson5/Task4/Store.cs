namespace Lesson5
{
    public class Store
    {
        private Article[] article;

        public string this[int index]
        {
            get
            {
                if (index < article.Length)
                {
                    return article[index].ToString();
                }

                return "Good with such index does not exist";
            }
        }

        public string this[string name]
        {
            get
            {
                for (int i = 0; i < article.Length; i++)
                {
                    if (name == article[i].GoodName)
                    {
                        return article[i].ToString();
                    }
                }

                return "Good is out of stock";
            }
        }

        public Store(Article[] articles)
        {
            article = new Article[articles.Length];

            for (int i = 0; i < articles.Length; i++)
            {
                article[i] = articles[i];
            }
        }
    }
}
