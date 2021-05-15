using System;

namespace _07_MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double minNum = int.MaxValue;

            while (input != "Stop")
            {
                int currentNum = int.Parse(input);

                if (currentNum < minNum)
                {
                    minNum = currentNum;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(minNum);
        }
    }
}
