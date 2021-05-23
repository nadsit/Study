using System;

namespace _01_2_Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfNylon = int.Parse(Console.ReadLine());
            int amountOfCombat = int.Parse(Console.ReadLine());
            int amountOfDiluent = int.Parse(Console.ReadLine());
            int hoursForTheWork = int.Parse(Console.ReadLine());

            double moneyForNylon = (amountOfNylon + 2) * 1.50;
            double moneyForCombat = amountOfCombat * 1.10 * 14.50;
            double moneyForDiluent = amountOfDiluent * 5.00;

            double totalMaterialExpenses = moneyForNylon + moneyForCombat + moneyForDiluent + 0.40;
            double mastersSalary = totalMaterialExpenses * 0.30 * hoursForTheWork;

            double result = totalMaterialExpenses + mastersSalary;

            Console.WriteLine($"Total expenses: {result:f2} lv.");
        }
    }
}
