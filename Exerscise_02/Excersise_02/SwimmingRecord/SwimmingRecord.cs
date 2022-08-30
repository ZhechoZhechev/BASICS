using System;

namespace SwimmingRecord
{
    class SwimmingRecord
    {
        static void Main()
        {
            double recordTime = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSecs = double.Parse(Console.ReadLine());
            double totalSec = distanceInMeters * timeInSecs;
            double delaySec = Math.Floor(distanceInMeters / (double)15);
            delaySec *= 12.5;

            double totalSecTime = totalSec + delaySec;

            if (totalSecTime < recordTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalSecTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(totalSecTime - recordTime):F2} seconds slower.");
            }
        }
    }
}
