using System;

namespace _06_VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                
                if(letter == 'a')
                {
                    result += 1;
                }
                else if(letter == 'e')
                {
                    result += 2;
                }
                else if (letter == 'i')
                {
                    result += 3;
                }
                else if (letter == 'o')
                {
                    result += 4;
                }
                else if (letter == 'u')
                {
                    result += 5;
                }       
            }

            Console.WriteLine(result);
        }
    }
}
