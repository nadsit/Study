using System;

namespace _06_NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string player = Console.ReadLine();

            string winnerName = "";
            int winnerPoints = 0;

            while(player != "Stop")
            {
                int currentPoints = 0;

                for (int i = 0; i < player.Length; i++)
                {
                    int number = int.Parse(Console.ReadLine());

                    if (number == player[i]) 
                    {
                        currentPoints += 10;
                    }
                    else
                    {
                        currentPoints += 2;
                    }
                }

                if(currentPoints >= winnerPoints)
                {
                    winnerPoints = currentPoints;
                    winnerName = player;
                }

                player = Console.ReadLine();
            }

            Console.WriteLine($"The winner is {winnerName} with {winnerPoints} points!");
        }
    }
}
