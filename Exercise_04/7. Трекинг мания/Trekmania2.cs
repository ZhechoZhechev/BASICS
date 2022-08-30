using System;

namespace _7._Трекинг_мания
{
    class Program
    {
        static void Main()
        {
            int groupsCount = int.Parse(Console.ReadLine());
            int ttlPplCount = 0;
            double musalaGroups = 0;
            double montBlanGroups = 0;
            double kilimanjaroGroups = 0;
            double k2Groups = 0;
            double everestGroups = 0;

            for (int i = 1; i <= groupsCount; i++)
            {
                int pplInEachGroup = int.Parse(Console.ReadLine());
                ttlPplCount += pplInEachGroup;
                if (pplInEachGroup <= 5)
                {
                    musalaGroups += pplInEachGroup;
                }
                else if (pplInEachGroup >= 6 && pplInEachGroup <= 12 )
                {
                    montBlanGroups += pplInEachGroup;
                }
                else if (pplInEachGroup >= 13 && pplInEachGroup <= 25)
                {
                    kilimanjaroGroups += pplInEachGroup;
                }
                else if (pplInEachGroup >= 26 && pplInEachGroup <= 40)
                {
                    k2Groups += pplInEachGroup;
                }
                else if (pplInEachGroup > 40)
                {
                    everestGroups += pplInEachGroup;
                }
            }
            Console.WriteLine($"{musalaGroups / ttlPplCount * 100:f2}%");
            Console.WriteLine($"{montBlanGroups / ttlPplCount * 100:f2}%");
            Console.WriteLine($"{kilimanjaroGroups / ttlPplCount * 100:f2}%");
            Console.WriteLine($"{k2Groups / ttlPplCount * 100:f2}%");
            Console.WriteLine($"{everestGroups / ttlPplCount * 100:f2}%");
        }
    }
}
