using System;

namespace Architect
{
    class Program
    {
        static void Main(string[] args)
        {
            String ArchName = Console.ReadLine();
            int ProjectNum = int.Parse(Console.ReadLine());
            var HoursNeeded = ProjectNum * 3;
            Console.WriteLine($"The architect {ArchName} will need {HoursNeeded} hours to complete {ProjectNum} project/s.");
        }
    }
}
