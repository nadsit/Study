using System;

namespace _03_OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double evenMaxNum = int.MinValue;
            double evenMinNum = int.MaxValue;
            double evenSum = 0;
            double oddMaxNum = int.MinValue;
            double oddMinNum = int.MaxValue;
            double oddSum = 0;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 1)
                {
                    oddSum += num;
                    
                    if (num < oddMinNum)
                    {
                        oddMinNum = num;                      
                    }

                    if (num > oddMaxNum)
                    {
                        oddMaxNum = num;                     
                    }
                }
                else 
                {
                    evenSum += num;

                    if (num < evenMinNum)
                    {
                        evenMinNum = num;                   
                    }

                    if (num > evenMaxNum)
                    {
                        evenMaxNum = num;               
                    }
                }
            }

            Console.WriteLine("OddSum={0:f2},", oddSum);

            if(oddMinNum == int.MaxValue)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine("OddMin={0:f2},", oddMinNum);
                Console.WriteLine("OddMax={0:f2},", oddMaxNum);
            }

            Console.WriteLine("EvenSum={0:f2},", evenSum);
            Console.WriteLine(evenMinNum == int.MaxValue ? "EvenMin=No," : "EvenMin={0:f2},", evenMinNum);
            Console.WriteLine(evenMaxNum == int.MinValue ? "EvenMax=No" : "EvenMax={0:f2}", evenMaxNum);
        }
    }
}
