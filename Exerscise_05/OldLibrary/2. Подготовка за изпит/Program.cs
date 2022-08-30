using System;

namespace _2._Подготовка_за_изпит
{
    class Program
    {
        static void Main()
        {
            int numFailsTreshold = int.Parse(Console.ReadLine());
            int numFailsCounter = 0;
            int gradesTotal = 0;
            int numOfProblemsTotal = 0;
            string lastProblem = "";
           
            while (true)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    numFailsCounter++;
                }
                if (numFailsCounter >= numFailsTreshold)
                {
                    Console.WriteLine($"You need a break, {numFailsCounter} poor grades.");
                    return;
                }
                gradesTotal += grade;
                numOfProblemsTotal++;
                lastProblem = problemName;
            }
            Console.WriteLine($"Average score: {gradesTotal / (double)numOfProblemsTotal:f2}");
            Console.WriteLine($"Number of problems: {numOfProblemsTotal}");
            Console.WriteLine($"Last problem: {lastProblem}");

        }
    }
}
