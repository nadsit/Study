using System;

namespace _05_MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMovies = int.Parse(Console.ReadLine());

            string movieHighestRating = "";
            double highestRating = double.MinValue;
            string movieLowestRating = "";
            double lowestRating = double.MaxValue;

            double averageRatingOfAllMovies = 0.0;

            for (int i = 0; i < numberOfMovies; i++)
            {
                string movieName = Console.ReadLine();
                double movieRating = double.Parse(Console.ReadLine());

                if (movieRating > highestRating) 
                {
                    highestRating = movieRating;
                    movieHighestRating = movieName;
                }

                if(movieRating < lowestRating)
                {
                    lowestRating = movieRating;
                    movieLowestRating = movieName;
                }
              
                averageRatingOfAllMovies += movieRating;
            }

            Console.WriteLine($"{movieHighestRating} is with highest rating: {highestRating:f1}");
            Console.WriteLine($"{movieLowestRating} is with lowest rating: {lowestRating:f1}");
            Console.WriteLine($"Average rating: {averageRatingOfAllMovies / numberOfMovies:f1}");
        }
    }
}
