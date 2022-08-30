using System;

namespace TrainTheTrainers
{
    class TrainTheTrainers
    {
        static void Main()
        {
            int juryNum = int.Parse(Console.ReadLine());
            int presentationCounter = 0;
            double totalAverrage = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Finish")
                {
                    break;
                }
                string presentationName = input; 
                presentationCounter++;
                double gradesForPresentation = 0;
                for (int juryMem = 1; juryMem <= juryNum; juryMem++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradesForPresentation += grade;
                }
                double averrageForPresentation = gradesForPresentation / juryNum;
                Console.WriteLine($"{presentationName} - {averrageForPresentation:f2}.");
                totalAverrage += averrageForPresentation;

            }
            double averrageForCourse = totalAverrage / presentationCounter;
            Console.WriteLine($"Student's final assessment is {averrageForCourse:f2}.");
        }
    }
}
