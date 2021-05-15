using System;

namespace _05_TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int startHours = int.Parse(Console.ReadLine());
            int startMinutes = int.Parse(Console.ReadLine());

            int timeInMinutes = startHours * 60 + startMinutes;
            int timePlus15Min = timeInMinutes + 15;

            int finalHours = timePlus15Min / 60;
            int finalMinutes = timePlus15Min % 60;

            if (finalHours >= 24)
            {
                finalHours -= 24;
            }

            if (finalMinutes >= 60)
            {
                finalMinutes -= 60;
            }

            if (finalMinutes < 10)
            {
                Console.WriteLine($"{finalHours}:0{finalMinutes}");
            }
            else
            {
                Console.WriteLine($"{finalHours}:{finalMinutes}");
            }
        }
    }
}
