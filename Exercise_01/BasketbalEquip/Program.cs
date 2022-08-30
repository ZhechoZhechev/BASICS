using System;

namespace BasketbalEquip
{
    class Program
    {
        static void Main(string[] args)
        {
            double fourtyPercent = 0.4;
            double twentyPercent = 0.2;

            int BasketballFee = int.Parse(Console.ReadLine());

            double BasketballShoes = BasketballFee - (BasketballFee * fourtyPercent);
            double BasketballClothes = BasketballShoes - (BasketballShoes * twentyPercent);
            double BasketballBall = BasketballClothes / 4;
            double BasketballAccesories = BasketballBall / 5;

            double TotalCost = BasketballFee + BasketballShoes + BasketballClothes + BasketballBall + BasketballAccesories;

            Console.WriteLine(TotalCost);
        }
    }
}
