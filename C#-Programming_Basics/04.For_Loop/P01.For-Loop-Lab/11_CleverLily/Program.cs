using System;

namespace _11_CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            double totalMoney = 0;
            int evenAgeSavings = 1;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    totalMoney += (10 * evenAgeSavings++) - 1;
                }
                else
                {
                    totalMoney += toysPrice;
                }
            }

            if (totalMoney >= laundryPrice)
            {
                Console.WriteLine($"Yes! {(totalMoney - laundryPrice):F2} ");
            }
            else
            {
                Console.WriteLine($"No! {(laundryPrice - totalMoney):F2}");
            }
        }
    }
}
