using System;

namespace Graduation
{
    class Program
    {
        static void Main()
        {
            string studentName = Console.ReadLine();
            double averageGrade = 0;
            int grade = 1;
            int fails = 0;

            while (grade <= 12)
            {
                double averageYearly = double.Parse(Console.ReadLine());
                averageGrade += averageYearly;
                if (averageYearly < 4)
                {
                    fails++;
                    if (fails >1)
                    {
                        Console.WriteLine($"{studentName} has been excluded at " +
                            $"{grade - 1} grade");
                        break;
                    }
                }
                grade++;

            }
            if (grade > 11)
            {
                Console.WriteLine($"{studentName} graduated. " +
                    $"Average grade: {averageGrade /12:f2}");
            }

        }
    }
}
