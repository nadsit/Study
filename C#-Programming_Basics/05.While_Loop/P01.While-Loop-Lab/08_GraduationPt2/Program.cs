using System;

namespace _08_GraduationPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string student = Console.ReadLine();
            int yearOfEducation = 0;
            double total = 0;

            while (yearOfEducation < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                yearOfEducation++;
                total += grade;

                if (grade < 4.00)
                {
                    Console.WriteLine($"{student} has been excluded at {yearOfEducation} grade");
                    break;
                }
            }

            if (yearOfEducation == 12)
            {
                total = total / 12;
                Console.WriteLine($"{student} graduated. Average grade: {total:F2}");
            }
        }
    }
}
