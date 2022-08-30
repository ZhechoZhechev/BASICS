using System;

namespace HotelRoom
{
    class HotelRoom
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double stayPriceStudio = 0.0;
            double stayPriceApp = 0.0;

            if (month == "May" || month == "October")
            {
                stayPriceStudio = nightsCount * 50;
                stayPriceApp = nightsCount * 65;
                if (nightsCount > 7 && nightsCount <= 14)
                {
                    stayPriceStudio *= 0.95;
                }
                else if (nightsCount > 14)
                {
                    stayPriceStudio *= 0.70;
                    stayPriceApp *= 0.90;
                }
            }
            if (month == "June" || month == "September")
            {
                stayPriceStudio = nightsCount * 75.20;
                stayPriceApp = nightsCount * 68.70;
                if (nightsCount > 14)
                {
                    stayPriceStudio *= 0.80;
                    stayPriceApp *= 0.90;
                }
            }
            if (month == "July" || month == "August")
            {
                stayPriceStudio = nightsCount * 76;
                stayPriceApp = nightsCount * 77;
                if (nightsCount > 14)
                {
                    stayPriceApp *= 0.90;
                }
            }
            Console.WriteLine($"Apartment: {stayPriceApp:f2} lv.");
            Console.WriteLine($"Studio: {stayPriceStudio:f2} lv.");
        }
        
    }
}
