using System;

namespace GreenYard
{
    class Program
    {
        static void Main(string[] args)
        {
            double m2 = Double.Parse(Console.ReadLine());
            double TotallPrice = m2 * 7.61;
            Double Discount = 0.18 * TotallPrice;
            Double FinalPrice = TotallPrice - Discount;
            Console.WriteLine($"The final price is: {FinalPrice} lv.");
            Console.WriteLine($"The discount is: {Discount}");
        }
    }
}
