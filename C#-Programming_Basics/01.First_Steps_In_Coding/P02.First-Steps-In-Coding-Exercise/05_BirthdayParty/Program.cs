using System;

namespace _05_BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallRentPrice = double.Parse(Console.ReadLine());

            double cakePrice = hallRentPrice * 0.20;
            double drinkPrice = cakePrice - (cakePrice * 0.45);
            double animatorPrice = hallRentPrice / 3;
            double sum = hallRentPrice + cakePrice + drinkPrice + animatorPrice;

            Console.WriteLine(sum);
        }
    }
}
