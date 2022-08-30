using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            double ChickenMenuPrice = 10.35;
            double FishMenuPrice = 12.40;
            double VegMenuPrice = 8.15;
            double DeliveryPrice = 2.50;
            double PercentageforDesert = 0.2;

            int ChickenMenus = int.Parse(Console.ReadLine());
            int FishMenus = int.Parse(Console.ReadLine());
            int VegMenus = int.Parse(Console.ReadLine());

            double TotalPriceChikenMenus = ChickenMenus * ChickenMenuPrice;
            double TotalPriceFishMenus = FishMenus * FishMenuPrice;
            double TotalPriceVegMenus = VegMenus * VegMenuPrice;

            double TotalPriceForMenus = TotalPriceChikenMenus + TotalPriceFishMenus + TotalPriceVegMenus;

            double DesertPrice = TotalPriceForMenus * PercentageforDesert;

            double TotalCostOfAll = TotalPriceForMenus + DesertPrice + DeliveryPrice;

            Console.WriteLine(TotalCostOfAll);


         
        }
    }
}
