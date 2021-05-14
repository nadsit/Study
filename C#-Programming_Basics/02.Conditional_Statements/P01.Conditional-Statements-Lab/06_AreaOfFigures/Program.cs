using System;

namespace _06_AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            double num = double.Parse(Console.ReadLine());
            double num2 = 0.0;

            double result = 0.0;

            if (figure == "square")
            {
                result = num * num;
            }
            else if (figure == "rectangle")
            {
                num2 = double.Parse(Console.ReadLine());
                result = num * num2;
            }
            else if (figure == "circle")
            {
                result = Math.PI * (num * num);
            }
            else if (figure == "triangle")
            {
                num2 = double.Parse(Console.ReadLine());
                result = (num * num2) / 2;
            }

            Console.WriteLine($"{result:f3}");
        }
    }
}
