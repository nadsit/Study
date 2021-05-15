using System;

namespace _07_WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentRecord = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            double recordAttemptInSeconds = meters * secondsPerMeter;
            double amountsOfTimeSlowedDown = Math.Floor(meters / 15);
            recordAttemptInSeconds = recordAttemptInSeconds + (amountsOfTimeSlowedDown * 12.5);

            if(recordAttemptInSeconds < currentRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {recordAttemptInSeconds:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {recordAttemptInSeconds - currentRecord:f2} seconds slower.");
            }
        }
    }
}
