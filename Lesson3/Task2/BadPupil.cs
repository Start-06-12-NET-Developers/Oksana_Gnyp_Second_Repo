using System;

namespace Lesson3
{
    public class BadPupil : Pupil 
    {
        public BadPupil(string name) : base(name)
        {
            
        }

        public override void Study()
        {
            Console.WriteLine("Pupil {0} - bad in study", Name);
        }

        public override void Read()
        {
            Console.WriteLine("Pupil {0} - bad in reading", Name);
        }

        public override void Write()
        {
            Console.WriteLine("Pupil {0} - bad in writting", Name);
        }

        public override void Relax()
        {
            Console.WriteLine("Pupil {0} - too much relax", Name);
        }
    }
}
