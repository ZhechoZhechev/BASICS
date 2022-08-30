using System;

namespace TennisRanklist
{
    class TennisRanklist
    {
        static void Main(string[] args)
        {
            int numTournaments = int.Parse(Console.ReadLine());
            int numPointsOfRankings = int.Parse(Console.ReadLine());
            int points = 0;
            double countTournament = 0.0;
            double countWonTournaments = 0.0;
            double pointsFromTournaments = 0.0;

            for (int currentTournament = 0; currentTournament < numTournaments; currentTournament++)
            {
                string resultOfTournament = Console.ReadLine();

                switch (resultOfTournament)
                {
                    case "W":
                        points += 2000;
                        countTournament += 1;
                        countWonTournaments += 1;
                        break;
                    case "F":
                        points += 1200;
                        countTournament += 1;
                        break;
                    case "SF":
                        points += 720;
                        countTournament += 1;
                        break;
                    default:
                        break;
                }
                numPointsOfRankings += points;
                pointsFromTournaments += points;
                points = 0;
            }
            double averageResult = pointsFromTournaments * 1.0 / countTournament;

            Console.WriteLine($"Final points: {numPointsOfRankings}");
            Console.WriteLine($"Average points: {Math.Floor(averageResult)}");
            Console.WriteLine($"{(countWonTournaments / countTournament) * 100:f2}%");
        }
    }
}