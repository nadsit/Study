using System;

namespace _05_AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double balance = 0;

            while(input != "NoMoreMoney")
            {
                double money = double.Parse(input);

                if(money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                balance += money;

                Console.WriteLine("Increase: {0:f2}", money);

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
