using System;

namespace _03_2_TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string typeOfPackage = Console.ReadLine();
            string vipDiscount = Console.ReadLine();
            int daysOfStay = int.Parse(Console.ReadLine());

            double price = 0.0;
            bool isValid = true;

            if (daysOfStay > 7)
            {
                daysOfStay--;
            }

            if (city == "Bansko" || city == "Borovets")
            {
                switch (typeOfPackage)
                {
                    case "noEquipment":
                        price = 80;

                        if(vipDiscount == "yes")
                        {
                            price *= 0.95;
                        }
                        break;
                    case "withEquipment":
                        price = 100;

                        if (vipDiscount == "yes")
                        {
                            price *= 0.90;
                        }
                        break;
                    default:
                        isValid = false;
                        break;
                }
            }
            else if (city == "Varna" || city == "Burgas")
            {
                switch (typeOfPackage)
                {
                    case "noBreakfast":
                        price = 100;

                        if (vipDiscount == "yes")
                        {
                            price *= 0.93;
                        }
                        break;
                    case "withBreakfast":
                        price = 130;

                        if (vipDiscount == "yes")
                        {
                            price *= 0.88;
                        }
                        break;
                    default:
                        isValid = false;
                        break;
                }
            }
            else
            {
                isValid = false;
            }

            double finalPrice = price * daysOfStay;

            if(isValid == false)
            {
                Console.WriteLine("Invalid input!");
            }
            else if(daysOfStay < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else
            {
                Console.WriteLine($"The price is {finalPrice:f2}lv! Have a nice time!");
            }
        }
    }
}
