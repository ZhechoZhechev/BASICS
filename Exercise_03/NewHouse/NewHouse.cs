using System;

namespace NewHouse
{
    class NewHouse
    {
        static void Main()
        {
            string flowerType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            
            double totalSpent = 0.0;
           
            if (flowerType == "Roses")
            {
                totalSpent = flowersCount * 5;
                if (flowersCount > 80)
                {
                    totalSpent *= 0.9; 
                }
            }
            if (flowerType == "Dahlias")
            {
                totalSpent = flowersCount * 3.80;
                if (flowersCount > 90)
                {
                    totalSpent *= 0.85;
                }
            }
            if (flowerType == "Tulips")
            {
                totalSpent = flowersCount * 2.80;
                if (flowersCount > 80)
                {
                    totalSpent *= 0.85;
                }
            }
            if (flowerType == "Narcissus")
            {
                totalSpent = flowersCount * 3;
                if (flowersCount < 120)
                {
                    totalSpent *= 1.15;
                }
            }
            if (flowerType == "Gladiolus")
            {
                totalSpent = flowersCount * 2.50;
                if (flowersCount < 80)
                {
                    totalSpent *= 1.20;
                }
            }
            if (budget >= totalSpent)
            {
                double sumLeft = budget - totalSpent;
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowerType}" +
                                  $" and {sumLeft:f2} leva left.");
            }
            else if (totalSpent > budget)
            {
                double sumNeeded = totalSpent - budget;
                Console.WriteLine($"Not enough money, you need {sumNeeded:f2} leva more.");
            }
        }
    }
}
