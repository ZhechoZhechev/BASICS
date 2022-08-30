using System;

namespace SumOfNums
{
    class SumOfNums
    {
        static void Main()
        {
            int lowerBorder = int.Parse(Console.ReadLine());
            int upperBorder = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinationsTotal = 0;


            for (int i = lowerBorder; i <= upperBorder ; i++)
            {
                for (int j = lowerBorder; j <= upperBorder; j++)
                {
                    combinationsTotal++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinationsTotal} ({i} + {j} = {magicNum})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinationsTotal} combinations - neither equals {magicNum}");

        }
    }
}
