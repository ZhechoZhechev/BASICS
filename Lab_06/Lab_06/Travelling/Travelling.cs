using System;

namespace Travelling
{
    class Travelling
    {
        static void Main()
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                double neededMoney = double.Parse(Console.ReadLine());
                while (neededMoney > 0)
                {
                double savedMoney = double.Parse(Console.ReadLine());
                    neededMoney -= savedMoney;

                    if (neededMoney <= 0)
                    {
                        Console.WriteLine($"Going to {destination}!");
                    }
                }
                destination = Console.ReadLine();
            }
        }
    }
}
