using System;

namespace HardwareShopping
{
    class HardwareShopping
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int gpuCount = int.Parse(Console.ReadLine());
            int cpuCount = int.Parse(Console.ReadLine());
            int ramCount = int.Parse(Console.ReadLine());

            double gpuPrice = gpuCount * 250;
            double cpuPriceSingle = gpuPrice * 0.35;
            double cpuPrice = cpuPriceSingle * cpuCount;
            double ramPriceSingle = gpuPrice * 0.10;
            double ramPrice = ramPriceSingle * ramCount;
            double totalPrice = gpuPrice + cpuPrice + ramPrice;
            if (gpuCount > cpuCount) 
            {
                totalPrice = totalPrice * 0.85;
            }
            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"You have {moneyLeft:F2} leva left!");
            }
            else if (totalPrice > budget) 
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva more!");
            }
            
        }
    }
}
