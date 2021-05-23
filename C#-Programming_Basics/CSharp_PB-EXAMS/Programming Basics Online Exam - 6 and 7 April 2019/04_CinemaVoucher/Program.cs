using System;

namespace _04_CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            double voucherAmount = double.Parse(Console.ReadLine());
            int purchasedTicketsCount = 0;
            int otherPurchases = 0;
            double ticketPrice = 0.0;

            string purchase = Console.ReadLine();

            while(purchase != "End")
            {
                if(purchase.Length > 8)
                {
                    int firstSymbol = purchase[0];
                    int secondSymbol = purchase[1];

                    ticketPrice = firstSymbol + secondSymbol;

                    if (ticketPrice <= voucherAmount)
                    {
                        voucherAmount -= ticketPrice; 
                        purchasedTicketsCount++;
                    }
                    else
                    {
                        break;
                    }                   
                }
                else
                {
                    ticketPrice = purchase[0];               

                    if (ticketPrice <= voucherAmount)
                    {
                        voucherAmount -= ticketPrice;
                        otherPurchases++;
                    }
                    else
                    {
                        break;
                    }
                }

                purchase = Console.ReadLine();
            }

            Console.WriteLine("{0}", purchasedTicketsCount);
            Console.WriteLine("{0}", otherPurchases);
        }
    }
}
