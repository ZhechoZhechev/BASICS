using System;

namespace SumOfNumbers
{
    class SumOfNumbers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (true)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                sum += inputNumber;
                if (number <= sum)
                {
                    
                    Console.WriteLine(sum);
                    break;
                }
                            

            }
        }
    }
}
