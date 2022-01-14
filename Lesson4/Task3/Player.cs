using System;

namespace Lesson4
{
    public class Player : IPlayable, IRecordable
    {
        void IPlayable.Pause()
        {
            Console.WriteLine("Pause listening");
        }

        void IPlayable.Play()
        {
            Console.WriteLine("Continue listening");
        }

        public void Record()
        {
            Console.WriteLine("Recording is on");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Pause recording");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Stop recording");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stop listening");
        }
    }
}
