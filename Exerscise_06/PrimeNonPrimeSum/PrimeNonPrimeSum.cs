using System;

namespace PrimeNonPrimeSum
{
    class PrimeNonPrimeSum
    {
        static void Main()
        {
            int primeSum = 0;
            int nonPrimeSum = 0;


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }
                int currentNum = int.Parse(input);
                if (currentNum < 0)
                {
                    Console.WriteLine($"Number is negative.");
                    continue;
                }
                bool isPrime = true;
                for (int divider = 2; divider < currentNum; divider++)
                {
                    if (currentNum % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeSum += currentNum;

                }
                else
                {
                    nonPrimeSum += currentNum;

                }


            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");



        }
    }
}
