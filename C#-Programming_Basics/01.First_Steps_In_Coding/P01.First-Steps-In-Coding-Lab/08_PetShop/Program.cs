using System;

namespace _08_PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDogs = int.Parse(Console.ReadLine());
            int numberOfOtherAnimals = int.Parse(Console.ReadLine());

            double finalAmount = numberOfDogs * 2.50 + numberOfOtherAnimals * 4;
            
            Console.WriteLine($"{finalAmount} lv.");
        }
    }
}
