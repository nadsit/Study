using System;

namespace _06_CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int pastryCook = int.Parse(Console.ReadLine());
            int cakesCount = int.Parse(Console.ReadLine());
            int wafflesCount = int.Parse(Console.ReadLine());
            int pancakesCount = int.Parse(Console.ReadLine());

            double dailyCakesIncomePerCook = cakesCount * 45;
            double dailyWafflesIncomePerCook = wafflesCount * 5.80;
            double dailyPancakesIncomePerCook = pancakesCount * 3.20;

            double totalIncome = (dailyCakesIncomePerCook + dailyWafflesIncomePerCook + dailyPancakesIncomePerCook) * pastryCook * days;

            double moneyRaised = totalIncome - (totalIncome / 8);

            Console.WriteLine(moneyRaised);
        }
    }
}
