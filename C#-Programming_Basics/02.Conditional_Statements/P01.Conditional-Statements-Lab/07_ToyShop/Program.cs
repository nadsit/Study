using System;

namespace _07_ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vaccationCost = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int toys = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            //пресметни броят на играчките
            int toysCount = puzzles + dolls + bears + toys + trucks;
            //пресметни печалбата без отстъпка
            double profit = puzzles * 2.60 + dolls * 3 + bears * 4.10 + toys * 8.20 + trucks * 2;
            //провери дали играчките са над 50 и ако да - сметни отстъпка и извади от печалбата
            if (toysCount >= 50)
            {
                profit = profit - 0.25 * profit;
            }
            //приспадни наема
            profit -= profit * 0.1;
            //провери дали парите за почивка са достатъчни
            if (profit >= vaccationCost)
            {
                Console.WriteLine($"Yes! {(profit - vaccationCost):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(vaccationCost - profit):F2} lv needed.");
            }
        }
    }
}
