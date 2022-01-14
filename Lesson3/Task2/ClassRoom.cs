using System;

namespace Lesson3
{
    public class ClassRoom
    {
        Pupil[] pupils = new Pupil[4];

        public ClassRoom(Pupil first = null, Pupil second = null, Pupil third = null, Pupil fourth = null)
        {
            this.pupils[0] = first;
            this.pupils[1] = second;
            this.pupils[2] = third;
            this.pupils[3] = fourth;
        }

        public void PupilsInfo()
        {
            foreach (Pupil pupil in pupils)
            {
                if (pupil != null)
                {
                    pupil.Study();
                    pupil.Read();
                    pupil.Write();
                    pupil.Relax();
                    Console.WriteLine("-------------------------------------------------");
                }
            }
        }
    }
}
