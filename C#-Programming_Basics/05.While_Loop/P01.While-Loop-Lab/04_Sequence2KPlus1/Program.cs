using System;

namespace _04_Sequence2KPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int k = 1;

            while(k <= num)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
            }
        }
    }
}
