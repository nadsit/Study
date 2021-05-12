using System;

namespace _04_InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberToConvert = double.Parse(Console.ReadLine());
            double inches = 2.54;

            double numberInCm = numberToConvert * 2.54;

            Console.WriteLine(numberInCm);
        }
    }
}
