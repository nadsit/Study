﻿using System;

namespace _08_CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();

            double ticketPrice = 0;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    ticketPrice = 12;
                    break;
                case "Wednesday":
                case "Thursday":
                    ticketPrice = 14;
                    break;
                case "Saturday":
                case "Sunday":
                    ticketPrice = 16;
                    break;
            }

            Console.WriteLine(ticketPrice);
        }
    }
}
