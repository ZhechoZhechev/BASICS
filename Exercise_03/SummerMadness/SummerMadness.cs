using System;

namespace SummerMadness
{
    class SummerMadness
    {
        static void Main()
        {
            //            От конзолата се четат точно два реда:
            // Градусите - цяло число в интервала[10…42]
            // Текст, време от денонощието - с възможности - &quot; Morning & quot;, &quot; Afternoon & quot;, &quot; Evening & quot;

            int degrees = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();
            string outfit = null;
            string shoes = null;

            if (degrees >= 10 && degrees <= 18)
            {
                if (partOfDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (partOfDay == "Afternoon" || partOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (degrees > 18 && degrees <= 24)
            {
                if (partOfDay == "Morning" || partOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (partOfDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (degrees >= 25)
            {
                if (partOfDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (partOfDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (partOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }

            }
            Console.WriteLine($"It's {degrees} degrees, " +
                $"get your {outfit} and {shoes}.");
        }
    }
}
