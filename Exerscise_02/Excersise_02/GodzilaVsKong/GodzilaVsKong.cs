using System;

namespace GodzilaVsKong
{
    class GodzilaVsKong
    {
        static void Main()
        {
            double filmBudget = double.Parse(Console.ReadLine());
            int walkOnS = int.Parse(Console.ReadLine());
            double walkOnClothPrice = double.Parse(Console.ReadLine());
            double walkOnClothPriceTotal = walkOnClothPrice * walkOnS;
            double decorsPrice = filmBudget * 0.1;
            
            if (walkOnS > 150) 
            {
                walkOnClothPriceTotal = walkOnClothPriceTotal * 0.9;
            }
            double totalMoneySpent =  walkOnClothPriceTotal + decorsPrice;
            if (totalMoneySpent > filmBudget)
            {
                double moneyNeeded = totalMoneySpent - filmBudget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            }
            else if (filmBudget >= totalMoneySpent) 
            {
                double moneyLeft = filmBudget - totalMoneySpent;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }

        }
    }
}
