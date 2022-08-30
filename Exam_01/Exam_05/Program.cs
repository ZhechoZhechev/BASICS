using System;

namespace Exam_05
{
    class Program
    {
        static void Main()
        {
            double trunkCappacity = double.Parse(Console.ReadLine());
            string input = string.Empty;
            int suitcaseCounter = 0;
            bool isSpaceFinished = false;
            int count = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                double suitcaseVolume = double.Parse(input);
                count++;
                if (count % 3 == 0)
                {
                    suitcaseVolume *= 1.10;
                }
                if (trunkCappacity < suitcaseVolume)
                {
                    isSpaceFinished = true;
                    break;
                }
                suitcaseCounter++;
                trunkCappacity -= suitcaseVolume;
            }
            if (isSpaceFinished)
            {
                Console.WriteLine("No more space!");
            }
            else
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {suitcaseCounter} suitcases loaded.");
        }
    }
}