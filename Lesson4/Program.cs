using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task2

            AbstractHandler doc = new DocHandler();
            AbstractHandler txt = new TXTHandler();
            AbstractHandler xml = new XMLHandler();

            doc.DocumentRedactor();

            #endregion

            #region Task3

            IPlayable player = new Player();
            player.Play();
            player.Stop();

            IRecordable recorder = (Player)player;
            recorder.Record();
            recorder.Stop();

            #endregion
            Console.ReadLine();
        }
    }
}
