using System;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double evenSum = 0;
            
            for (int i = 0; i < n; i++) 
            {
                int currentNum = int.Parse(Console.ReadLine());
                bool OddEven = i % 2 == 0;
                
                if (OddEven)
                {
                    evenSum += currentNum;
                }
                else
                {
                    oddSum += currentNum;
                }

            }
            if (oddSum == evenSum)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs(oddSum - evenSum)}");
            }
        }
    }
}
