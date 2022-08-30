using System;

namespace _09._Ski_Trip
{
    class SkyTrip
    {
        static void Main(string[] args)
        {
            int daysOfHoliday = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string rating = Console.ReadLine();

            double priceHoliday = 0.0;

            switch (typeOfRoom)
            {
                case "room for one person":
                    priceHoliday = (daysOfHoliday - 1) * 18;
                    break;
                case "apartment":
                    if (daysOfHoliday < 10)
                    {
                        priceHoliday = ((daysOfHoliday - 1) * 25) * 0.7;
                    }
                    else if (daysOfHoliday >= 10 && daysOfHoliday <= 15)
                    {
                        priceHoliday = ((daysOfHoliday - 1) * 25) * 0.65;
                    }
                    else if (daysOfHoliday > 15)
                    {
                        priceHoliday = ((daysOfHoliday - 1) * 25) * 0.5;
                    }
                    break;
                case "president apartment":
                    if (daysOfHoliday < 10)
                    {
                        priceHoliday = ((daysOfHoliday - 1) * 35) * 0.9;
                    }
                    else if (daysOfHoliday >= 10 && daysOfHoliday <= 15)
                    {
                        priceHoliday = ((daysOfHoliday - 1) * 35) * 0.85;
                    }
                    else if (daysOfHoliday > 15)
                    {
                        priceHoliday = ((daysOfHoliday - 1) * 35) * 0.8;
                    }
                    break;
                default:
                    break;
            }
            if (rating == "positive")
            {
                priceHoliday *= 1.25;
            }
            else if (rating == "negative")
            {
                priceHoliday *= 0.9;
            }
            Console.WriteLine($"{priceHoliday:f2}");
        }
    }
}