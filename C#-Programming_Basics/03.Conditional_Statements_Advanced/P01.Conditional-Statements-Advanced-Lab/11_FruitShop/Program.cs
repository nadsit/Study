using System;

namespace _11_FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double priceOfFruit = 0.0;

            if(day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        priceOfFruit = 2.70;
                        break;
                    case "apple":
                        priceOfFruit = 1.25;
                        break;
                    case "orange":
                        priceOfFruit = 0.90;
                        break;
                    case "grapefruit":
                        priceOfFruit = 1.60;
                        break;
                    case "kiwi":
                        priceOfFruit = 3.00;
                        break;
                    case "pineapple":
                        priceOfFruit = 5.60;
                        break;
                    case "grapes":
                        priceOfFruit = 4.20;
                        break;
                    default:
                        Console.WriteLine("error");
                        return;
                }
            }
            else if(day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        priceOfFruit = 2.50;
                        break;
                    case "apple":
                        priceOfFruit = 1.20;
                        break;
                    case "orange":
                        priceOfFruit = 0.85;
                        break;
                    case "grapefruit":
                        priceOfFruit = 1.45;
                        break;
                    case "kiwi":
                        priceOfFruit = 2.70;
                        break;
                    case "pineapple":
                        priceOfFruit = 5.50;
                        break;
                    case "grapes":
                        priceOfFruit = 3.85;
                        break;
                    default:
                        Console.WriteLine("error");
                        return;          
                }
            }
            else
            {
                Console.WriteLine("error");
                return;
            }

            double result = priceOfFruit * quantity;

            Console.WriteLine($"{result:f2}");
        }
    }
}
