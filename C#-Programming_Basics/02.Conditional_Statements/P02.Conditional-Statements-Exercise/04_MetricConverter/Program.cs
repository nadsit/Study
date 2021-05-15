using System;

namespace _04_MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputNumber = double.Parse(Console.ReadLine());
            string inputMetrics = Console.ReadLine();
            string outputMetrics = Console.ReadLine();

            double inputNumberInCm = inputNumber;

            if(inputMetrics == "mm")
            {
                inputNumberInCm = inputNumber / 10;
            }
            else if(inputMetrics == "m")
            {
                inputNumberInCm = inputNumber * 100;
            }

            double outputNumber = inputNumberInCm;

            if(outputMetrics == "mm")
            {
                outputNumber = inputNumberInCm * 10;
            }
            else if(outputMetrics == "m")
            {
                outputNumber = inputNumberInCm / 100;
            }

            Console.WriteLine($"{outputNumber:f3}");
        }
    }
}
