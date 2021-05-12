using System;

namespace _07_ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architect = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());

            Console.WriteLine($"The architect {architect} will need {numberOfProjects * 3} hours to complete {numberOfProjects} project/s.");        
        }
    }
}
