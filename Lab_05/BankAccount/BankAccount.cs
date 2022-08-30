using System;

namespace BankAccount
{
    class BankAccount
    {
     
        static void Main(string[] args)
        {
            double balance = 0;

            while (true)
            {
                string token = Console.ReadLine();
                if (token == "NoMoreMoney")
                {
                    break;
                }
                double increase = double.Parse(token);
                if (increase < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                balance += increase;
                Console.WriteLine($"Increase: {increase:f2}");
            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
