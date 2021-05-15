using System;

namespace _04_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int stepsGoal = 10_000;
            int totalNumberOfSteps = 0;

            while ((totalNumberOfSteps >= stepsGoal) == false)
            {
                string input = Console.ReadLine();

                if(input == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    totalNumberOfSteps += stepsToHome;
                    break;
                }

                int steps = int.Parse(input);
                totalNumberOfSteps += steps;
            }

            if(totalNumberOfSteps >= stepsGoal)
            {
                Console.WriteLine($"Goal reached! Good job!\r\n{totalNumberOfSteps - stepsGoal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{stepsGoal - totalNumberOfSteps} more steps to reach goal.");
            }
        }
    }
}
