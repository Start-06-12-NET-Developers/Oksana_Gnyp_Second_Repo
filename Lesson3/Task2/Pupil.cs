namespace Lesson3
{
    public class Pupil
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Pupil(string name)
        {
            this.name = name;
        }

        public virtual void Study() { }

        public virtual void Read() { }

        public virtual void Write() { }

        public virtual void Relax() { }
    }
}
