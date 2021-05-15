using System;

namespace _03_NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            const double rosesPrice = 5;
            const double dahliasPrice = 3.80;
            const double tulipsPrice = 2.80;
            const double narcissusPrice = 3;
            const double gladiolusPrice = 2.50;

            double price = 0;
            double discount = 1;

            if(flowersType == "Roses")
            {
                price = rosesPrice;

                if(count > 80)
                {
                    discount = 0.9;
                }
            }
            else if(flowersType == "Dahlias")
            {
                price = dahliasPrice;

                if (count > 90)
                {
                    discount = 0.85;
                }
            }
            else if (flowersType == "Tulips")
            {
                price = tulipsPrice;

                if (count > 80)
                {
                    discount = 0.85;
                }
            }
            else if (flowersType == "Narcissus")
            {
                price = narcissusPrice;

                if (count < 120)
                {
                    discount = 1.15;
                }
            }
            else if (flowersType == "Gladiolus")
            {
                price = gladiolusPrice;

                if (count < 80)
                {
                    discount = 1.2;
                }
            }

            double totalPrice = (count * price) * discount;

            if(budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flowersType} and {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:f2} leva more.");
            }
        }
    }
}
