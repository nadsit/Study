using System;

namespace _02_GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int numberOfExtras = int.Parse(Console.ReadLine());
            double priceForClothing = double.Parse(Console.ReadLine());

            double amountForDecor = movieBudget * 0.1;
            double amountForClothing = numberOfExtras * priceForClothing;

            if(numberOfExtras > 150)
            {
                amountForClothing = amountForClothing - (amountForClothing * 0.1);
            }

            double totalMovieSum = amountForDecor + amountForClothing;

            if(totalMovieSum > movieBudget)
            {
                Console.WriteLine("Not enough money!" + "\r\n" + $"Wingard needs {Math.Abs(movieBudget - totalMovieSum):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!" + "\r\n" + $"Wingard starts filming with {movieBudget - totalMovieSum:f2} leva left.");
            }
        }
    }
}
