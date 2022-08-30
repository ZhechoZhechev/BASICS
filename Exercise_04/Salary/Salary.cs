using System;

namespace Salary
{
    class Salary
    {
        static void Main()
        {
            int countSites = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int fine = 0;

            for (int i = 0; i < countSites; i++)
            {
                string siteName = Console.ReadLine();

                if (siteName == "Facebook")
                {
                    fine += 150;
                }
                else if (siteName == "Instagram")
                {
                    fine += 100;
                }
                else if (siteName == "Reddit")
                {
                    fine += 50;
                }
                else
                {
                    fine += 0;
                }
                if (fine >= salary)
                {
                    Console.WriteLine($"You have lost your salary.");
                    break;
                }

            }if (fine < salary)
            {
                int whatsLeftFromSalary = salary - fine;
                Console.WriteLine($"{whatsLeftFromSalary}");
            }

        }
    }
}
