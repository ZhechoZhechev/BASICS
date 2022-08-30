using System;

namespace FishingBoat
{
    class FishingBoat
    {
        static void Main()
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermenCount = int.Parse(Console.ReadLine());
            double finalPrice = 0.0;

            if (season == "Spring")
            {
                finalPrice = 3000;
                if (fishermenCount <= 6)
                {
                    finalPrice *= 0.9;
                }
                else if (fishermenCount > 6 && fishermenCount <= 11)
                {
                    finalPrice *= 0.85;
                }
                else if (fishermenCount > 12)
                {
                    finalPrice *= 0.75;
                }

            }
            else if (season == "Summer" || season == "Autumn") 
            {
                finalPrice = 4200;
                if (fishermenCount <= 6)
                {
                    finalPrice *= 0.9;
                }
                else if (fishermenCount > 6 && fishermenCount <= 11)
                {
                    finalPrice *= 0.85;
                }
                else if (fishermenCount > 12)
                {
                    finalPrice *= 0.75;
                }
            }
            else if (season == "Winter")
            {
                finalPrice = 2600;
                if (fishermenCount <= 6)
                {
                    finalPrice *= 0.9;
                }
                else if (fishermenCount > 6 && fishermenCount <= 11)
                {
                    finalPrice *= 0.85;
                }
                else if (fishermenCount > 12)
                {
                    finalPrice *= 0.75;
                }

            }
            bool even = fishermenCount % 2 == 0;
            if (even == true && season != "Autumn" )
            {
                finalPrice *= 0.95;
            }
            if (budget >= finalPrice)
            {
                double moneyLeft = budget - finalPrice;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else if (finalPrice > budget)
            {
                double moneyNeeded = finalPrice - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }
        }
    }
}
