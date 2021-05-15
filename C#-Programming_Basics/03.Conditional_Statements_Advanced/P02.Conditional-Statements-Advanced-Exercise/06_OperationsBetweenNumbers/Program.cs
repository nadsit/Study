using System;

namespace _06_OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            string action = Console.ReadLine();

            double result = 0;
            string bonus = "";

            if(action == "+")
            {
                result = firstNumber + secondNumber;

                if(result % 2 == 0)
                {
                    bonus = "even";
                } 
                else
                {
                    bonus = "odd";
                }

                Console.WriteLine($"{firstNumber} + {secondNumber} = {result} - {bonus}");
            }
            else if(action == "-")
            {
                result = firstNumber - secondNumber;

                if (result % 2 == 0)
                {
                    bonus = "even";
                }
                else
                {
                    bonus = "odd";
                }

                Console.WriteLine($"{firstNumber} - {secondNumber} = {result} - {bonus}");
            }
            else if (action == "*")
            {
                result = firstNumber * secondNumber;

                if (result % 2 == 0)
                {
                    bonus = "even";
                }
                else
                {
                    bonus = "odd";
                }

                Console.WriteLine($"{firstNumber} * {secondNumber} = {result} - {bonus}");
            }
            else if (action == "/")
            {
                if(secondNumber == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                    return;
                }

                result = firstNumber / secondNumber;

                Console.WriteLine($"{firstNumber} / {secondNumber} = {result:f2}");

            }
            else if (action == "%")
            {
                if (firstNumber == 0 || secondNumber == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }
                else
                {
                    result = firstNumber % secondNumber;

                    Console.WriteLine($"{firstNumber} % {secondNumber} = {result}");
                }
            }
        }
    }
}
