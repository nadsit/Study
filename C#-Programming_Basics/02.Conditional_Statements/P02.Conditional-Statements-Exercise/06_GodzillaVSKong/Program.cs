using System;

namespace _06_GodzillaVSKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double pricePerCostume = double.Parse(Console.ReadLine());

            double amountForDecor = budget * 0.10;
            double amountForClothing = extras * pricePerCostume;

            if(extras >= 150)
            {
                amountForClothing = amountForClothing * 0.90;
            }

            double totalMoneyForMovie = amountForDecor + amountForClothing;

            if(budget >= totalMoneyForMovie)
            {
                Console.WriteLine($"Action!\r\nWingard starts filming with {budget - totalMoneyForMovie:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money!\r\nWingard needs {totalMoneyForMovie - budget:f2} leva more.");
            }
        }
    }
}
