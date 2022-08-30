using System;

namespace ToyShop
{
    class ToyShop
    {
        static void Main()
        {

            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double puzzlesTotalLv = puzzles * 2.60;
            double dollsTotalLv = dolls * 3;
            double bearsTotalLv = bears * 4.10;
            double minionsTotalLv = minions * 8.20;
            double trucksTotalLv = trucks * 2;

            double TotalSum = puzzlesTotalLv + dollsTotalLv + bearsTotalLv
                                            + minionsTotalLv + trucksTotalLv;
            double ToysCount = puzzles + dolls + bears + minions + trucks;
           
            if (ToysCount >= 50) 
            {
                TotalSum = TotalSum * 0.75;
            }
            TotalSum = TotalSum * 0.9;
            if (TotalSum >= tripPrice) 
            {
                double remainingMoney = TotalSum - tripPrice;
                Console.WriteLine($"Yes! { remainingMoney:F2} lv left.");
            }
            else if (TotalSum < tripPrice)
            {
                double missingMoney = tripPrice - TotalSum;
                Console.WriteLine($"Not enough money! {missingMoney:F2} lv needed.");
            }



        }
    }
}
