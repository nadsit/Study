using System;

namespace _06_MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double maxNum = int.MinValue;

            while(input != "Stop")
            {
                int currentNum = int.Parse(input);

                if(currentNum > maxNum)
                {
                    maxNum = currentNum;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(maxNum);
        }
    }
}
