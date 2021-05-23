using System;

namespace _06_2_TheMostPowerfulWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "";

            string mostPowerfulWord = "";
            double mostPowerfulWordSum = 0.0;

            while ((word = Console.ReadLine()) != "End of words")
            {
                double sum = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    sum += word[i];
                }

               
                string wordToLower = word.ToLower();
                char firstLetter = wordToLower[0];

                if (firstLetter == 'a' ||
                    firstLetter == 'e' ||
                    firstLetter == 'i' ||
                    firstLetter == 'o' ||
                    firstLetter == 'u' ||
                    firstLetter == 'y')
                {
                    sum *= word.Length;
                }
                else
                {
                   sum = Math.Floor(sum / word.Length);
                }

                if(sum > mostPowerfulWordSum)
                {
                    mostPowerfulWord = word;
                    mostPowerfulWordSum = sum;
                }
            }

            Console.WriteLine($"The most powerful word is {mostPowerfulWord} - {mostPowerfulWordSum}");
        }
    }
}
