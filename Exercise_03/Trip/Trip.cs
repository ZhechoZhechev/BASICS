using System;

namespace Trip
{
    class Trip
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = null;
            string campOrHotel = null;
            double finalCost = 0.0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    finalCost = budget * 0.3;
                    campOrHotel = "Camp";
                }
                else if (season == "winter")
                {
                    finalCost = budget * 0.7;
                    campOrHotel = "Hotel";
                }
            }
            else if (budget > 100 && budget <= 1000) 
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    finalCost = budget * 0.4;
                    campOrHotel = "Camp";
                }
                else if (season == "winter")
                {
                    finalCost = budget * 0.8;
                    campOrHotel = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                finalCost = budget * 0.9;
                campOrHotel = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{campOrHotel} - {finalCost:f2} ");
            
        }
    }
}
