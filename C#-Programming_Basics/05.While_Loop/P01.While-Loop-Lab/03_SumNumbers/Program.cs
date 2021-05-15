using System;

namespace _03_SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int result = 0;

            while (result < num)
            {
                int currentNum = int.Parse(Console.ReadLine());

                result += currentNum;
            }

            Console.WriteLine(result);
        }
    }
}
