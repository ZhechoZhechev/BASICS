using System;

namespace Oscars
{
    class Oscars
    {
        static void Main()
        {
            string actorName = Console.ReadLine();
            double accademyPoints = double.Parse(Console.ReadLine());
            int judgesNum = int.Parse(Console.ReadLine());
            double pointsSum = accademyPoints;

            for (int i = 1; i <= judgesNum; i++)
            {
                string judgeName = Console.ReadLine();
                double pointGiven = double.Parse(Console.ReadLine());

                double pointsByjudge = judgeName.Length * pointGiven / 2;
                pointsSum += pointsByjudge;
                if (pointsSum > 1250.5)
                {
                    break;
                }
            }
            if (pointsSum > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {pointsSum:f1}!");
            }
            else if (1250.5 > pointsSum)
            {
                double pointsNeeded = 1250.5 - pointsSum;
                Console.WriteLine($"Sorry, {actorName} you need {pointsNeeded:f1} more!");
            }
        } 

    }
}
