﻿using System;

namespace _10_OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += int.Parse(Console.ReadLine());
                }
                else
                {
                    oddSum += int.Parse(Console.ReadLine());
                }

            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
            }
        }
    }
}
