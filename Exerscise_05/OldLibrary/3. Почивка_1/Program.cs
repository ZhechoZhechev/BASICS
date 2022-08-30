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

            while (daysSpendCounter < 5)
            {
                string command = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                daysCounter++;
                if (command == "save")
                {
                    jessyBudget += sum;
                    daysSpendCounter = 0;
                }
                else if (command == "spend")
                {
                    jessyBudget -= sum;
                    daysSpendCounter++;
                    if (jessyBudget < 0)
                    {
                        jessyBudget = 0;
                    }
                }
                if (moneyNeeded <= jessyBudget)
                {
                    Console.WriteLine($"You saved the money for {daysCounter} days.");
                    break;
                }
            }
            if (daysSpendCounter >= 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
        }
    }
}
