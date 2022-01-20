using System;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task2

            string[] cooking = new string[]
            {
                "How",
                "to",
                "cook",
                "fish",
                "with",
                "nuts"
            };

            FindReplaceManager.FindNext("fish", cooking);

            #endregion

            #region Task3

            Book.Notes notes = new Book.Notes();
            notes.Save("My findings");

            #endregion

            #region Task4

            new int[] { 4, 6, 2 }.SortArray();

            #endregion

            Console.ReadKey();
        }
    }
}
