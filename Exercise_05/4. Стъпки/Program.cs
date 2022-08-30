using System;

namespace _4._Стъпки
{
    class Program
    {
        static void Main()
        {
            int stepsCouner = 0;
            int stepsToBeReached = 10000;
           
            while (stepsCouner <= stepsToBeReached)
            {
                string command = Console.ReadLine();
                if (command != "Going home")
                {
                    int steps = int.Parse(command);
                    stepsCouner += steps;
                }
                else if (command == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    stepsCouner += stepsToHome;
                        break;
                }
            }
            if (stepsCouner >= stepsToBeReached)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsCouner - stepsToBeReached} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(stepsCouner - stepsToBeReached)} more steps to reach goal.");
            }


        }
    }
}
