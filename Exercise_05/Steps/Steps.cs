using System;

namespace Steps
{
    class Steps
    {
        static void Main()
        {
            int steps = 0;
            while (steps < 10000)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    input = Console.ReadLine();
                    steps += int.Parse(input); 
                    break;
                }
                else
                {
                    steps += int.Parse(input);
                }
            }
            if (steps >= 10000)
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{steps - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - steps} more steps to reach goal.");
            }
        }
    }
}
