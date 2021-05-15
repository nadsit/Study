using System;

namespace _06_Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());

            int cakeSize = cakeWidth * cakeLength;

            string input = string.Empty;

            while((input = Console.ReadLine()) != "STOP")
            {
                int eatenPieces = int.Parse(input);

                cakeSize -= eatenPieces;

                if(cakeSize <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
                    break;
                }
            }

            if(cakeSize > 0)
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }
        }
    }
}
