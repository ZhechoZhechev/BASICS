using System;

namespace MathsForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int PercentageDivider = 100;
            int PackPens = int.Parse(Console.ReadLine());
            int PackMarkers = int.Parse(Console.ReadLine());
            int BBoardCleanerLitters = int.Parse(Console.ReadLine());
            Double DiscountPercentage = Double.Parse(Console.ReadLine())/PercentageDivider;
            Double PricePens = PackPens * 5.80;
            Double PriceMarkers = PackMarkers * 7.20;
            Double PriceBoardCleaner = BBoardCleanerLitters * 1.20;
            Double TotalPriceWithoutDisc = PricePens + PriceMarkers + PriceBoardCleaner;
            Double Discount = TotalPriceWithoutDisc * DiscountPercentage;
            Double FinalSum = TotalPriceWithoutDisc - Discount;
            Console.WriteLine(FinalSum);

        }
    }
}
