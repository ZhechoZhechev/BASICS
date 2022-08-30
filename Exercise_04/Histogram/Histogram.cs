using System;

namespace Histogram
{
    class Histogram
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double numsUnder200 = 0;
            double numsBetween200and399 = 0;
            double numsBetween400and599 = 0;
            double numsBetween600and799 = 0;
            double numsOver800 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    numsUnder200++;
                }
                else if (num >= 200 && num < 400)
                {
                    numsBetween200and399++;
                }
                else if (num >= 400 && num < 600)
                {
                    numsBetween400and599++;
                }
                else if (num >= 600 && num < 800)
                {
                    numsBetween600and799++;
                }
                else if (num >= 800)
                {
                    numsOver800++;
                }
                
            }
            Console.WriteLine($"{numsUnder200 / n * 100:f2}%");
            Console.WriteLine($"{numsBetween200and399 / n * 100:f2}%");
            Console.WriteLine($"{numsBetween400and599 / n * 100:f2}%");
            Console.WriteLine($"{numsBetween600and799 / n * 100:f2}%");
            Console.WriteLine($"{numsOver800 / n * 100:f2}%");
        }
    }
}
