using System;

namespace _03_DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());

            double interestPercentage = interest / 100;

            double result = deposit + months * ((deposit * interestPercentage) / 12);

            Console.WriteLine(result);
        }
    }
}
