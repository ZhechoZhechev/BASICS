using System;

namespace Exam_01
{
    class Program
    {
        static void Main()
        {
            int easterBread = int.Parse(Console.ReadLine());
            int eggPacks = int.Parse(Console.ReadLine());
            int cookiesKgs = int.Parse(Console.ReadLine());

            double easterBreadPrice = easterBread * 3.20;
            double eggsPrice = eggPacks * 4.35;
            double cookiesPrice = cookiesKgs * 5.40;
            double eggsPaint = (eggPacks * 12) * 0.15;

            double totalLuchCost = easterBreadPrice + eggsPrice + cookiesPrice + eggsPaint;
            Console.WriteLine($"{totalLuchCost:f2}");
        }
    }
}
