using System;

namespace TrekMania
{
    class TrekMania
    {
        static void Main()
        {
            int groupCount = int.Parse(Console.ReadLine());
            double percentMusalaClimbers = 0;
            double percentMontBlancClimbers = 0;
            double percentKilimanjaroClimbers = 0;
            double percentK2Climbers = 0;
            double percentEverestClimbers = 0;
            
            int totalPplCount = 0;

            for (int i = 1; i <= groupCount; i++)
            {
                int pplPerGroupCount = int.Parse(Console.ReadLine());
                totalPplCount += pplPerGroupCount;

                if (pplPerGroupCount <= 5)
                {
                    percentMusalaClimbers += pplPerGroupCount;
                }
                else if (pplPerGroupCount > 5 && pplPerGroupCount <= 12)
                {
                    percentMontBlancClimbers += pplPerGroupCount;
                }
                else if (pplPerGroupCount > 12 && pplPerGroupCount <=25)
                {
                    percentKilimanjaroClimbers += pplPerGroupCount;
                }
                else if (pplPerGroupCount > 25 && pplPerGroupCount <= 40)
                {
                    percentK2Climbers += pplPerGroupCount;
                }
                else if (pplPerGroupCount > 40)
                {
                    percentEverestClimbers += pplPerGroupCount;
                }
            }
            Console.WriteLine($"{percentMusalaClimbers / totalPplCount * 100:f2}%");
            Console.WriteLine($"{percentMontBlancClimbers / totalPplCount * 100:f2}%");
            Console.WriteLine($"{percentKilimanjaroClimbers / totalPplCount * 100:f2}%");
            Console.WriteLine($"{percentK2Climbers / totalPplCount * 100:f2}%");
            Console.WriteLine($"{percentEverestClimbers / totalPplCount * 100:f2}%");
        }
    }
}
