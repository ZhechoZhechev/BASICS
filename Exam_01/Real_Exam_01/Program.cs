using System;

namespace Real_Exam_01
{
    class Program
    {
        static void Main()
        {
            int startHeight = 5364;
            int targetHeight = 8848;
            int curentHeight = 0;
            int daysCount = 1;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                if (command == "Yes")
                {
                    daysCount++;
                }
                int height = int.Parse(Console.ReadLine());
                curentHeight += height;
                if (curentHeight + startHeight >= targetHeight)
                {
                    break;
                }
                if (daysCount == 5)
                {
                    break;
                }
            }
            if (startHeight + curentHeight < targetHeight)
            {
                Console.WriteLine("Failed!");
                Console.WriteLine($"{startHeight + curentHeight}");
            }
            else
            {
                Console.WriteLine($"Goal reached for {daysCount} days!");
            }
        }
    }
}
