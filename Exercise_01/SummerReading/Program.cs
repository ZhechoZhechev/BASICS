using System;

namespace SummerReading
{
    class Program
    {
        static void Main(string[] args)
        {

            int Pages = int.Parse(Console.ReadLine());
            int PagesPerHour = int.Parse(Console.ReadLine());
            int DaysToCompleteTheBook = int.Parse(Console.ReadLine());
            int TotalHours = Pages / PagesPerHour;
            int Totaldays = TotalHours / DaysToCompleteTheBook;
            Console.WriteLine(Totaldays);
            

        }
    }
}
