using System;

namespace Exam_06
{
    class Program
    {
        static void Main()
        {
            int tournamentDays = int.Parse(Console.ReadLine());
            int gamesWonTotal = 0;
            int gamesLostTotal = 0;
            double charityBox = 0;
            for (int i = 1; i <= tournamentDays; i++)
            {
                string input = string.Empty;
                int gamesWonPerDay = 0;
                int gamesLostPerDay = 0;
                double charityBoxPerday = 0;
                while ((input = Console.ReadLine()) != "Finish")
                {
                    string winOrLoose = Console.ReadLine();
                    if (winOrLoose == "win")
                    {
                        charityBoxPerday += 20;
                        gamesWonPerDay++;
                        gamesWonTotal++;
                    }
                    else
                    {
                        gamesLostPerDay++;
                        gamesLostTotal++;
                    }
                    
                }
                if (gamesWonPerDay > gamesLostPerDay)
                {
                    charityBoxPerday *= 1.10;
                }
                charityBox += charityBoxPerday;

            }
            if (gamesWonTotal > gamesLostTotal)
            {
                charityBox *= 1.20;
                Console.WriteLine($"You won the tournament! Total raised money: {charityBox:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {charityBox:f2}");
            }

        }
    }
}
