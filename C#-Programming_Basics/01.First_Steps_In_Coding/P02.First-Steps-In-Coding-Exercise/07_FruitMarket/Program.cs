using System;

namespace _07_FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberryPricePerKg = double.Parse(Console.ReadLine());
            double bananasKg = double.Parse(Console.ReadLine());
            double orangesKg = double.Parse(Console.ReadLine());
            double rasberriesKg = double.Parse(Console.ReadLine());
            double strawberriesKg = double.Parse(Console.ReadLine());

            double rasberryPricePerKg = strawberryPricePerKg / 2;
            double orangesPricePerKg = rasberryPricePerKg * 0.6;
            double bananasPricePerKg = rasberryPricePerKg * 0.2;

            double strawberriesPrice = strawberryPricePerKg * strawberriesKg;
            double rasberriesPrice = rasberryPricePerKg * rasberriesKg;
            double orangesPrice = orangesPricePerKg * orangesKg;
            double bananasPrice = bananasPricePerKg * bananasKg;

            double totalPrice = strawberriesPrice + rasberriesPrice + orangesPrice + bananasPrice;

            Console.WriteLine($"{totalPrice:f2}");
        } 
    }
}
