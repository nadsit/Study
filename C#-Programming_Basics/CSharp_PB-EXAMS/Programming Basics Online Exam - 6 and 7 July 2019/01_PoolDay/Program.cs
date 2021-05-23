using System;

namespace _01_PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            double fee = double.Parse(Console.ReadLine());
            double deckChairPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            double totalFee = numberOfPeople * fee;
            double totalMoneyForDeckChair = Math.Ceiling(numberOfPeople * 0.75) * deckChairPrice;
            double totalMoneyForUmbrella = Math.Ceiling(numberOfPeople * 0.5) * umbrellaPrice;


            double totalMoney = totalFee + totalMoneyForDeckChair + totalMoneyForUmbrella;

            Console.WriteLine($"{totalMoney:f2} lv.");
        }
    }
}
