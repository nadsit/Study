using System;

namespace _08_FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());
            percentage = percentage * 0.01;

            double volume = length * width * height;
            // (1 m³ е равен на 1000 литра) 0,001 m3 или един кубичен дециметър (dm3).
            double totalLiters = volume * 0.001;

            double realLitersNeeded = totalLiters - (totalLiters * percentage);

            Console.WriteLine(realLitersNeeded);
        }
    }
}
