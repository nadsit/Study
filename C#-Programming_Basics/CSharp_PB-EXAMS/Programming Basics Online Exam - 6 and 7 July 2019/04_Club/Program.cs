using System;

namespace _04_Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double desiredProfit = double.Parse(Console.ReadLine());

            string cocktail = Console.ReadLine();
            double currentProfit = 0.0;

            while (cocktail != "Party!" && currentProfit < desiredProfit)
            {
                int numberOfCocktails = int.Parse(Console.ReadLine());

                double orderPrice = numberOfCocktails * cocktail.Length;

                if(orderPrice % 2 == 1)
                {
                    orderPrice *= 0.75;
                }

                currentProfit += orderPrice;

                cocktail = Console.ReadLine();
            }

            if(cocktail == "Party!")
            {
                Console.WriteLine($"We need {desiredProfit - currentProfit:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Target acquired.");
            }

            Console.WriteLine($"Club income - {currentProfit:f2} leva.");
        }
    }
}
