using System;

namespace TimePlus15
{
    class TimePlus15
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int minutesPlus15 = minutes + 15;
            
            if (minutesPlus15 <= 59) 
            {
                Console.WriteLine($"{hours}:{minutesPlus15}"); 
            }
            else if(minutesPlus15 > 59) 
            {
                minutes = minutesPlus15 - 60;
                hours += 1;
                if(hours > 23) 
                {
                    hours = 0;
                }

                Console.WriteLine($"{hours}:{minutes:D2}");
            }

        }
    }
}
