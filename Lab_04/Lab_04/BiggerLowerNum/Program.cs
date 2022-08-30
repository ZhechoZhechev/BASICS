using System;

namespace BiggerLowerNum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            for (int i = 0; i < n; i++) 
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }
                if (currentNum < minNum)
                {
                    minNum = currentNum;
                }

            }
            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
        }
    }
}
