using System;

namespace _04_2_Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            int total = height * width * 4;
            double wallsForPainting = Math.Ceiling(total - total * (percent / 100.0));

            string input = Console.ReadLine();

            while (input != "Tired!" && wallsForPainting >= 0)
            {
                int litersOfPaint = int.Parse(input);

                wallsForPainting -= litersOfPaint;

                input = Console.ReadLine();
            }

            if(wallsForPainting == 0)
            {
                Console.WriteLine("All walls are painted! Great job, Pesho!");
            }
            else if(wallsForPainting > 0)
            {
                Console.WriteLine($"{wallsForPainting} quadratic m left.");
            }
            else
            {
                Console.WriteLine($"All walls are painted and you have {Math.Abs(wallsForPainting)} l paint left!"); // num * -1
            }
        }
    }
}
