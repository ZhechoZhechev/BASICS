using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double PaintPrice = 14.50;
            double PaintThinnerPrice = 5.00;
            double NailonPrice = 1.50;
            double SumForBags = 0.40;
            double ThirthyPercent = 0.3;
            int AdditionalNailon = 2;

            int NailonSqM = int.Parse(Console.ReadLine());
            int PaintLitters = int.Parse(Console.ReadLine());
            int PaintThinnerLiters = int.Parse(Console.ReadLine());
            int HoursNeededToComplete = int.Parse(Console.ReadLine());
            
            

            double TotalPaint = PaintLitters * 1.1;
            double TotalNailon = NailonSqM + AdditionalNailon;

            double TotalPaintPrice = TotalPaint * PaintPrice;
            double TotalNailonPrice = TotalNailon * NailonPrice;
            double TotalThinnerPrice = PaintThinnerLiters * PaintThinnerPrice;

            double MatherialsPrice = TotalPaintPrice + TotalNailonPrice + TotalThinnerPrice + SumForBags;

            double WorkersHourlyFee = MatherialsPrice * ThirthyPercent;

            double TotalForWorkers = WorkersHourlyFee * HoursNeededToComplete;

            double totalPriceOfAll = MatherialsPrice + TotalForWorkers;

            Console.WriteLine(totalPriceOfAll);
        }
    }
}
