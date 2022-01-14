using System;

namespace Lesson3
{
    public class GoodPupil : Pupil
    {
        public GoodPupil(string name) : base(name)
        {

        }

        public override void Study()
        {
            Console.WriteLine("Pupil {0} - good in study", Name);
        }

        public override void Read()
        {
            Console.WriteLine("Pupil {0} - good in reading", Name);
        }

        public override void Write()
        {
            Console.WriteLine("Pupil {0} - good in writting", Name);
        }

        public override void Relax()
        {
            Console.WriteLine("Pupil {0} - keep study-relax balance", Name);
        }
    }
}
