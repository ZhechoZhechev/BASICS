﻿using System;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main()
        {
            int maxNumber = int.MinValue;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }
                int number = int.Parse(input);
                if (number > maxNumber )
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine(maxNumber);
        }
        
    }
}
