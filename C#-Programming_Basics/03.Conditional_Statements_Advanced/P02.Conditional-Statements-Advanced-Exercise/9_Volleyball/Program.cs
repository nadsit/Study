using System;

namespace _9_Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int holidaysCount = int.Parse(Console.ReadLine());
            int homeTripsCount = int.Parse(Console.ReadLine());

            const int weekendsCount = 48;

            double holidaysGames = holidaysCount * (2.0 / 3.0);
            double homeTripsGames = homeTripsCount;
            double sofiaGames = (weekendsCount - homeTripsCount) * (3.0 / 4.0);

            double totalGames = holidaysGames + homeTripsGames + sofiaGames;

            if(yearType == "leap")
            {
                totalGames += totalGames * 0.15;
            }

            Console.WriteLine($"{Math.Floor(totalGames)}");
        }
    }
}
