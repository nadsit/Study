using System;

namespace _09_YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double greenLand = double.Parse(Console.ReadLine());

            double priceGreening = greenLand * 7.61;
            double discount = greenLand * 7.61 * 0.18;
            double finalPrice = priceGreening - discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}