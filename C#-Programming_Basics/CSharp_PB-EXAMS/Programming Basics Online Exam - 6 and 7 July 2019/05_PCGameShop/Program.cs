using System;

namespace _05_PCGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesSold = int.Parse(Console.ReadLine());
            
            int hearthstoneCount = 0;
            int forniteCount = 0;
            int overwatchCount = 0;
            int othersCount = 0;

            for (int i = 0; i < gamesSold; i++)
            {
                string game = Console.ReadLine();

                switch (game)
                {
                    case "Hearthstone":
                        hearthstoneCount++;
                        break;
                    case "Fornite":
                        forniteCount++;
                        break;
                    case "Overwatch":
                        overwatchCount++;
                        break;
                    default:
                        othersCount++;
                        break;
                }
            }

            Console.WriteLine($"Hearthstone - {hearthstoneCount * 1.0 / gamesSold * 100:f2}%");
            Console.WriteLine($"Fornite - {forniteCount * 1.0 / gamesSold * 100:f2}%");
            Console.WriteLine($"Overwatch - {overwatchCount * 1.0 / gamesSold * 100:f2}%");
            Console.WriteLine($"Others - {othersCount * 1.0 / gamesSold * 100:f2}%");
        }
    }
}
