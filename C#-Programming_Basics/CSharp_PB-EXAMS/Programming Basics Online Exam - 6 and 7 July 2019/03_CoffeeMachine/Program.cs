using System;

namespace _03_CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numberOfDrinks = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (drink == "Espresso")
            {
                switch (sugar)
                {
                    case "Without":
                        price = 0.90;
                        break;
                    case "Normal":
                        price = 1;
                        break;
                    case "Extra":
                        price = 1.20;
                        break;
                }
            }
            else if (drink == "Cappuccino")
            {
                switch (sugar)
                {
                    case "Without":
                        price = 1.00;
                        break;
                    case "Normal":
                        price = 1.20;
                        break;
                    case "Extra":
                        price = 1.60;
                        break;
                }
            }
            else if (drink == "Tea")
            {
                switch (sugar)
                {
                    case "Without":
                        price = 0.50;
                        break;
                    case "Normal":
                        price = 0.60;
                        break;
                    case "Extra":
                        price = 0.70;
                        break;

                }
            }

            double totalPrice = price * numberOfDrinks;
            double discount = 0.0;

            if (sugar == "Without")
            {
                discount = totalPrice * 0.35;
                totalPrice -= discount;
            }

            if (drink == "Espresso" && numberOfDrinks > 5)
            {
                discount = totalPrice * 0.25;
                totalPrice -= discount;
            }

            if (totalPrice > 15)
            {
                discount = totalPrice * 0.20;
                totalPrice -= discount;
            }

            Console.WriteLine($"You bought {numberOfDrinks} cups of {drink} for {totalPrice:f2} lv.");
        }
    }
}
