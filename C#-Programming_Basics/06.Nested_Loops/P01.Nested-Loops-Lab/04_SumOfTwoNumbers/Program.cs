using System;

namespace _04_SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;
            bool isFound = false;

            for (int i = startInterval; i <= endInterval; i++)
            {
                for (int j = startInterval; j <= endInterval; j++)
                {
                    combinations++;

                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicNumber})");
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                    break;
            }

            if (isFound == false)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
            }
        }
    }
}
