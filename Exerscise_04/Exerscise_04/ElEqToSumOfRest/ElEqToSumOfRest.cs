using System;

namespace ElEqToSumOfRest
{
    class ElEqToSumOfRest
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }
            }
            int sumWithoutMaxNumber = sum - max;
            if (sumWithoutMaxNumber == max)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs(sumWithoutMaxNumber - max)}");
            }
        }



    }
    
}
