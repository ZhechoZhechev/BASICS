using System;

namespace DepositCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Double PercentageDivider = 100;
            double DepositSum = double.Parse(Console.ReadLine());
            int DepositTerm = int.Parse(Console.ReadLine());
            Double Intrest = Double.Parse(Console.ReadLine())/PercentageDivider;
            Double IntrestPerMonth = (DepositSum * Intrest) / 12;
            double Totalsum = DepositSum + DepositTerm * IntrestPerMonth;
            Console.WriteLine(Totalsum);
        }
    }
}
