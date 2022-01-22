using System;
using System.Linq;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task2

            Train.EnterTrainInfo();
            Train.GetTrainInfo();

            #endregion

            #region Task5

            Notebook notebook = new Notebook("SB", "SP", 100);
            notebook.NotebookInfo();

            #endregion

            Console.ReadKey();
        }
    }

    struct Train
    {
        private string destination;
        private int trainNumber;
        private DateTime departureTime;

        private static Train[] trains;
        private static IOrderedEnumerable<Train> sortedTrains;

        public string Destination
        {
            get
            {
                return destination;
            }
        }

        public int TrainNumber
        {
            get
            {
                return trainNumber;
            }
        }

        public DateTime DepartureTime
        {
            get
            {
                return departureTime;
            }
        }

        public Train(string destination, int trainNumber, DateTime departureTime)
        {
            this.destination = destination;
            this.trainNumber = trainNumber;
            this.departureTime = departureTime;
        }

        public static void EnterTrainInfo()
        {
            trains = new Train[8];
           
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Fill in destination");
                string destination = Console.ReadLine();
                Console.WriteLine("Enter train number");
                int trainNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter departureTime");
                DateTime departureTime = Convert.ToDateTime(Console.ReadLine());

                trains[i] = new Train(destination, trainNumber, departureTime);
            }

            sortedTrains = from train in trains
                           orderby train.TrainNumber
                           select train;
        }

        public static void GetTrainInfo()
        {
            if (trains.Length > 0)
            {
                Console.WriteLine("Enter train number");
                int number = Convert.ToInt32(Console.ReadLine());
                var exist = sortedTrains.FirstOrDefault(item => item.TrainNumber == number);

                if (exist.TrainNumber == number)
                {
                    Console.WriteLine(exist.ToString());
                }
                else
                {
                    Console.WriteLine("Train number is not valid!");
                }
            }
            else
            {
                Console.WriteLine("Trains info is not available!");
            }
        }

        public override string ToString()
        {
            return $"Destination: {destination}, Train Number: {trainNumber}, Departure Time: {departureTime}";
        }
    }
}
