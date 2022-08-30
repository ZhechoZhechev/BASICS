using System;

namespace Vacation
{
    class Vacation
    {
        static void Main()
        {
            double vacationCosts = double.Parse(Console.ReadLine());
            double moneyStack = double.Parse(Console.ReadLine());
            int daysCOunter = 0;
            int spendingCouner = 0;

            while (moneyStack < vacationCosts && spendingCouner < 5)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCOunter++;
                if (command == "save")
                {
                    moneyStack += money;
                    spendingCouner = 0;
                }
                else if (command == "spend")
                {
                    moneyStack -= money;
                    spendingCouner++;
                    if (moneyStack <= 0)
                    {
                        moneyStack = 0;
                    }

                }

            }
            if (spendingCouner == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{daysCOunter}");
            }
            if (moneyStack >= vacationCosts)
            {
                Console.WriteLine($"You saved the money for {daysCOunter} days.");
            }


        }
    }
}
