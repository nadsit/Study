using System;

namespace _04_TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countOfPresentations = 0;
            double totalSumOfGrades = 0;

            string presentation = Console.ReadLine();

            while(presentation != "Finish")
            {
                countOfPresentations++;
                double sumOfGrades = 0;

                for (int i = 0; i < n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumOfGrades += grade;
                }

                double averageGrade = sumOfGrades / n;
                Console.WriteLine($"{presentation} - {averageGrade:f2}.");

                totalSumOfGrades += averageGrade;

                presentation = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {totalSumOfGrades / countOfPresentations:f2}.");
        }
    }
}
