using System;

namespace Cinema
{
    class Cinema
    {
        static void Main()
// Premiere – премиерна прожекция, на цена 12.00 лева.
// Normal – стандартна прожекция, на цена 7.50 лева.
// Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
        {
            string typeP = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double income = 0.0;
            if (typeP == "Premiere")
            {
                income = rows * columns * 12.00;

            }
            else if (typeP == "Normal")
            {
                income = rows * columns * 7.50;
            }
            else if (typeP == "Discount")
            {
                income = rows * columns * 5.00;

            }
            Console.WriteLine($"{income:f2} leva");

        }
    }
}
