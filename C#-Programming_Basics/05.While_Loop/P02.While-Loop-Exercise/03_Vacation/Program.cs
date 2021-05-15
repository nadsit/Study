using System;

namespace _03_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spendingCounter = 0;

            while (ownedMoney < neededMoney && spendingCounter < 5) 
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;

                if(command == "save")
                {
                    ownedMoney += money;
                    spendingCounter = 0;
                }
                else if(command == "spend")
                {
                    if (ownedMoney - money <= 0)
                    {
                        ownedMoney = 0;
                    }
                    else if(ownedMoney - money > 0)
                    {
                        ownedMoney -= money;                
                    }

                    spendingCounter++;
                }
            }

            if (spendingCounter == 5) 
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }

            if(ownedMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
