using System;

namespace CleverLily
{
    class CleverLily
    {
        static void Main()
        {
            int age = int.Parse(Console.ReadLine());
            double washMachinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            double moneyBox = 0;
            double moneyGift = 10;
            int toysNum = 0;
            

            for (int i = 1; i <= age; i++)
            {
                double birthdaysCounter = i % 2;
                if (birthdaysCounter == 0)
                {
                    moneyBox += moneyGift;
                    moneyBox--;
                    moneyGift += 10;

                }
                else
                {
                    toysNum++;
                }
                
            }
            double totalFromToys = toysNum * toyPrice;
            double cashTotalFromBirthdays = totalFromToys + moneyBox;

            if (cashTotalFromBirthdays >= washMachinePrice)
            {
                double moneyLeft = cashTotalFromBirthdays - washMachinePrice;
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else if (washMachinePrice > cashTotalFromBirthdays)
            {
                double moneyNeeded = washMachinePrice - cashTotalFromBirthdays;
                Console.WriteLine($"No! {moneyNeeded:f2}");
            }


        }
    }
}
