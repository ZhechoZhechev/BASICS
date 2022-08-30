using System;

namespace ExamPrep
{
    class ExamPrep
    {
        static void Main()
        {
            int failedTreshold = int.Parse(Console.ReadLine());
            int failsCouner = 0;
            int solvedProblemsCount = 0;
            double gradesSum = 0;
            string lastProblem = string.Empty;
            bool isFailed = true;

            while (failsCouner < failedTreshold)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failsCouner++;
                }
                solvedProblemsCount++;
                gradesSum += grade;
                lastProblem = problemName;

            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedTreshold} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum / solvedProblemsCount:f2}");
                Console.WriteLine($"Number of problems: {solvedProblemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
