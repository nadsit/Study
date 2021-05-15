using System;

namespace _09_Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int totalboxes = 0;

            int freeSpaceVolume = width * length * height;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                int numberOfBoxes = int.Parse(input);

                freeSpaceVolume -= numberOfBoxes;

                if (freeSpaceVolume <= 0) 
                {
                    Console.WriteLine($"No more free space! You need {totalboxes - freeSpaceVolume} Cubic meters more.");
                    break;
                }

                input = Console.ReadLine();
            }

            if(input == "Done")
            {
                Console.WriteLine($"{freeSpaceVolume - totalboxes} Cubic meters left.");
            }
        }
    }
}
