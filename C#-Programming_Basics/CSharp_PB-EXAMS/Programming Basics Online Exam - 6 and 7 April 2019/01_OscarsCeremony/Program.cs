using System;

namespace _01_OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int hallRent = int.Parse(Console.ReadLine());

            double statuettesPrice = hallRent - (hallRent * 0.3);
            double cateringPrice = statuettesPrice - (statuettesPrice * 0.15);
            double soundSystemPrice = cateringPrice / 2;

            double totalCostPrice = hallRent + statuettesPrice + cateringPrice + soundSystemPrice;

            Console.WriteLine($"{totalCostPrice:f2}");
        }
    }
}
