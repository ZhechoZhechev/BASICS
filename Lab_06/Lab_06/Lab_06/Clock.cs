﻿using System;

namespace Lab_06
{
    class Clock
    {
        static void Main()
        {
            for (int hours = 0; hours <= 23; hours++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    Console.WriteLine($"{hours}:{minutes}");
                }
            }
        }
    }
}
