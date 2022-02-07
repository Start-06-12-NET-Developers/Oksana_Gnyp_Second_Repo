namespace Lesson11
{
    public class Car<T, K> where T : class
                           where K : struct
    {
        private T model;
        private K number;

        public T Model
        {
            get
            {
                return model;
            }
        }

        public K Number
        {
            get
            {
                return number;
            }
        }

        public Car(T model, K number)
        {
            this.model = model;
            this.number = number;
        }

        public override string ToString()
        {
            return Model + "," + Number;
        }
    }
}
