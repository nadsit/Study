using System;

namespace _03_OscarsWeekInCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            string typeHall = Console.ReadLine();
            int numberOfTickets = int.Parse(Console.ReadLine());

            double price = 0.0;

            if(movieName == "A Star Is Born")
            {
                switch (typeHall)
                {
                    case "normal":
                        price = 7.50;
                        break;
                    case "luxury":
                        price = 10.50;
                        break;
                    case "ultra luxury":
                        price = 13.50;
                        break;
                }
            }
            else if(movieName == "Bohemian Rhapsody")
            {
                switch (typeHall)
                {
                    case "normal":
                        price = 7.35;
                        break;
                    case "luxury":
                        price = 9.45;
                        break;
                    case "ultra luxury":
                        price = 12.75;
                        break;
                }
            }
            else if (movieName == "Green Book")
            {
                switch (typeHall)
                {
                    case "normal":
                        price = 8.15;
                        break;
                    case "luxury":
                        price = 10.25;
                        break;
                    case "ultra luxury":
                        price = 13.25;
                        break;
                }
            }
            else if (movieName == "The Favourite")
            {
                switch (typeHall)
                {
                    case "normal":
                        price = 8.75;
                        break;
                    case "luxury":
                        price = 11.55;
                        break;
                    case "ultra luxury":
                        price = 13.95;
                        break;
                }
            }

            double movieIncome = numberOfTickets * price;

            Console.WriteLine($"{movieName} -> {movieIncome:f2} lv.");
        }
    }
}
