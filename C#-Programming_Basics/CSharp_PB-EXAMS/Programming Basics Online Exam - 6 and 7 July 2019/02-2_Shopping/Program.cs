using System;

namespace _02_2_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfVideoCards = int.Parse(Console.ReadLine());
            int numberOfProcessors = int.Parse(Console.ReadLine());
            int numberOfRAMMemory = int.Parse(Console.ReadLine());

            double moneyForVideoCards = numberOfVideoCards * 250;
            double moneyForProcessors = numberOfProcessors * (moneyForVideoCards * 0.35);
            double moneyForRAMMemory = numberOfRAMMemory * (moneyForVideoCards * 0.1);

            double totalMoney = moneyForVideoCards + moneyForProcessors + moneyForRAMMemory;

            if(numberOfVideoCards > numberOfProcessors)
            {
                totalMoney *= 0.85;
            }

            if(totalMoney <= budget)
            {
                Console.WriteLine($"You have {budget - totalMoney:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalMoney - budget:f2} leva more!");
            }
        }
    }
}
