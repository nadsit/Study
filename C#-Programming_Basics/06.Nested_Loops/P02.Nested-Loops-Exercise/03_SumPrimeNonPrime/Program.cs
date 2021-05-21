using System;

namespace _03_SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int primeSum = 0;
            int nonPrimeSum = 0;

            while(input != "stop")
            {
                int currentNum = int.Parse(input);

                if(currentNum < 0)
                {
                    Console.WriteLine("Number is negative.");

                    input = Console.ReadLine();
                    continue;
                }

                bool isNotPrime = false;

                for (int i = 2; i < currentNum; i++)
                {
                    if(currentNum % i == 0)
                    {
                        isNotPrime = true;
                        break;
                    }
                }

                if(isNotPrime)
                {
                    nonPrimeSum += currentNum;
                }
                else
                {
                    primeSum += currentNum;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
