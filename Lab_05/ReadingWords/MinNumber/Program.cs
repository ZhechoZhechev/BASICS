using System;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main()
        {
            int minNumber = int.MaxValue;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }
                int number = int.Parse(input);
                if (number < minNumber)
                {
                    minNumber = number;
                }
            }
            Console.WriteLine(minNumber);
        }

    }
}
