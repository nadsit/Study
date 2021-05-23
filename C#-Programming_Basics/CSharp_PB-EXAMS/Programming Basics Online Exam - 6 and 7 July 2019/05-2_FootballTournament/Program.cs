using System;

namespace _05_2_FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string footballTeam = Console.ReadLine();
            int playedMatches = int.Parse(Console.ReadLine());

            if(playedMatches == 0)
            {
                Console.WriteLine($"{footballTeam} hasn't played any games during this season.");
                return;
            }

            int gamesWon = 0;
            int gamesDraw = 0;
            int gamesLost = 0;

            for (int i = 0; i < playedMatches; i++)
            {
                char meetingOutcome = char.Parse(Console.ReadLine());

                switch(meetingOutcome)
                {
                    case 'W':
                        gamesWon++;
                        break;
                    case 'D':
                        gamesDraw++;
                        break;
                    case 'L':
                        gamesLost++;
                        break;
                }
            }

            int totalPoints = gamesWon * 3 + gamesDraw * 1; 

            Console.WriteLine($"{footballTeam} has won {totalPoints} points during this season.");
            Console.WriteLine($"Total stats:");
            Console.WriteLine($"## W: {gamesWon}");
            Console.WriteLine($"## D: {gamesDraw}");
            Console.WriteLine($"## L: {gamesLost}");
            Console.WriteLine($"Win rate: {gamesWon * 1.0 / playedMatches * 100:f2}%");
        }
    }
}
