using System;

namespace Lesson3
{
    public class ExelentPupil : Pupil
    {
        public ExelentPupil(string name) : base(name)
        {

        }

        public override void Study()
        {
            Console.WriteLine("Pupil {0} - excelent in study", Name);
        }

        public override void Read()
        {
            Console.WriteLine("Pupil {0} - excelent in reading", Name);
        }

        public override void Write()
        {
            Console.WriteLine("Pupil {0} - excelent in writting", Name);
        }

        public override void Relax()
        {
            Console.WriteLine("Pupil {0} - need more relax", Name);
        }
    }
}
