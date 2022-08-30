using System;

namespace BonusPoints
{
    class BonusPoints
    {
        static void Main()
        {
            int startingPoints = int.Parse(Console.ReadLine());
            double BonusPoints = 0;
            

            if (startingPoints <= 100)
            {
                BonusPoints = 5;
            }
            else if (startingPoints > 100 && startingPoints <= 1000)
            {
                BonusPoints = startingPoints * 0.2;
            }
            else if (startingPoints > 100) 
            {
                BonusPoints = startingPoints * 0.1;
            }
            if (startingPoints % 2 == 0)
            {
                BonusPoints += 1;
            }
            else if (startingPoints % 10 == 5) 
            {
                BonusPoints += 2;
            }
            Console.WriteLine(BonusPoints);
            Console.WriteLine(BonusPoints + startingPoints);
        }
       

    }
}
