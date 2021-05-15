using System;

namespace _07_WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            bool isWorkingDay = true;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    break;
                case "Sunday":
                    isWorkingDay = false;
                    break;
            }

            if (hour >= 10 && hour <= 18 && isWorkingDay)
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
