using System;

namespace Excersise_02
{
    class SecondSum
    {
        static void Main()
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int timeSum = firstTime + secondTime + thirdTime;

            int minutes = timeSum / 60;
            int seconds = timeSum % 60;
            if (seconds < 9)
            {
                Console.WriteLine($"{minutes}:0{seconds} ");

            }
            else 
            {
                Console.WriteLine($"{minutes}:{seconds}");
                    
            }
        }
    }
}
