using System;

namespace LunchBreak
{
    class LunchBreak
    {
        static void Main()
        {
            string seriesName = Console.ReadLine();
            int timePerEp = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());
            double lunchTime = breakTime * (double)1 / 8;
            double restTime = breakTime * (double)1 / 4;
            double timeLeftForWatching = breakTime - (lunchTime + restTime);

            if (timeLeftForWatching >= timePerEp)
            {
                double timeLeft = timeLeftForWatching - timePerEp;
                Console.WriteLine($"You have enough time to watch {seriesName}" +
                    $" and left with {Math.Ceiling(timeLeft)} minutes free time.");
            }
            else if (timePerEp > timeLeftForWatching) 
            {
                double timeNeeded = timePerEp - timeLeftForWatching;
                Console.WriteLine($"You don't have enough time to watch {seriesName}," +
                    $" you need {Math.Ceiling(timeNeeded)} more minutes.");
            }


        }
    }
}
