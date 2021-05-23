using System;

namespace _06_CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int totalTickets = 0;
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            while (movie != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());
                string ticket = Console.ReadLine();
                int countOfTickets = 0;

                while (ticket != "End")
                {
                    switch (ticket)
                    {
                        case "student":
                            studentTickets++;
                            break;
                        case "standard":
                            standardTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            break;
                    }

                    countOfTickets++;

                    if (countOfTickets == availableSeats)
                    {
                        break;
                    }

                    ticket = Console.ReadLine();
                }

                totalTickets += countOfTickets;
                double percentOfSeatsTaken = (double)countOfTickets / availableSeats * 100;

                Console.WriteLine($"{movie} - {percentOfSeatsTaken:f2}% full.");

                movie = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {totalTickets}");

            double percentOfStudentTickets = (double)studentTickets / totalTickets * 100;
            double percentOfStandardTickets = (double)standardTickets / totalTickets * 100;
            double percentOfKidTickets = (double)kidTickets / totalTickets * 100;

            Console.WriteLine($"{percentOfStudentTickets:f2}% student tickets.");
            Console.WriteLine($"{percentOfStandardTickets:f2}% standard tickets.");
            Console.WriteLine($"{percentOfKidTickets:f2}% kids tickets.");
        }
    }
}
