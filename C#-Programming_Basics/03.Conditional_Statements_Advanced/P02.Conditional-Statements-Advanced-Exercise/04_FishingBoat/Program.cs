using System;

namespace _04_FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermansCount = int.Parse(Console.ReadLine());

            double boatPrice = 0;

            switch(season)
            {
                case "Spring":
                        boatPrice = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    boatPrice = 4200;
                    break;
                case "Winter":
                    boatPrice = 2600;
                    break;
            }

            double discount = 1;

            if(fishermansCount <= 6)
            {
                discount = 0.9;
            }
            else if(fishermansCount <= 11)
            {
                discount = 0.85;
            }
            else 
            {
                discount = 0.75;
            }

            double bonusDiscount = 1;

            if(fishermansCount % 2 == 0 && season != "Autumn")
            {
                bonusDiscount = 0.95;
            }

            double totalPrice = (boatPrice * discount) * bonusDiscount;

            if(budget >= totalPrice)
            {
                Console.WriteLine($"Yes! You have {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva.");
            }
        }
    }
}
