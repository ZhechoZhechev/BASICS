using System;

namespace Exam_02
{
    class Program
    {
        static void Main()
        {
            int wins = 0;
            int draws = 0;
            int looses = 0;


            for (int i = 1; i <=  3; i++)
            {
                string matchResult = Console.ReadLine();
                char homeTeam = matchResult[0];
                char awayTeam = matchResult[2];
                if (homeTeam > awayTeam)
                {
                    wins++;
                }
                else if (homeTeam == awayTeam)
                {
                    draws++;
                }
                else
                {
                    looses++;
                }
            }
            Console.WriteLine($"Team won {wins} games.");
            Console.WriteLine($"Team lost {looses} games.");
            Console.WriteLine($"Drawn games: {draws}");

        }
    }
}
