﻿using System;

namespace realExam_02
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 9; b >= a; b--)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 9; d >= c; d--)
                        {
                            int sum = (a + b + c + d);
                            int multiplication = (a * b * c * d);
                            if (sum == multiplication && num % 10 == 5)
                            {
                                Console.WriteLine($"{a}{b}{c}{d}");
                                return;
                            }
                            if (multiplication/sum == 3 && num % 3 == 0)
                            {
                                Console.WriteLine($"{d}{c}{b}{a}");
                                return;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Nothing found");
        }
    }
}
