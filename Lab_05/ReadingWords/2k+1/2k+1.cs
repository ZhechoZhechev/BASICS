﻿using System;

namespace _2k_1
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int k = 1;
            while (k <= number)
            {
                Console.WriteLine(k);
                k = 2 * k + 1;
            }
        }
    }
}
