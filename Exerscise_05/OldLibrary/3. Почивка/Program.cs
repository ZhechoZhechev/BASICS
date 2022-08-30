using System;

namespace _3._Почивка
{
    class Program
    {
        static void Main()
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double jessyBudget = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int daysSpendCounter = 0;

            while (daysCounter < 5 && jessyBudget < moneyNeeded )
            {
                string command = Console.ReadLine();
                int sum = int.Parse(Console.ReadLine());
                daysCounter++;
                if (command == "save" )
                {
                    jessyBudget += sum;
                    daysSpendCounter = 0;
                }
                else if (command == "spend")
                {
                    jessyBudget -= sum;
                    daysSpendCounter++;
                    if (jessyBudget < sum)
                    {
                        jessyBudget = 0;
                    }
                }
            }
            if (daysCounter >= 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            else if (moneyNeeded <= jessyBudget)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
