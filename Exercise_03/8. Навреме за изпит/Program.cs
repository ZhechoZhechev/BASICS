using System;

namespace _8._Навреме_за_изпит
{
    class Program
    {
        static void Main()
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int delay = 0;
            int early = 0;

            int examHoursInMins = (examHour * 60) + examMinutes;
            int arrivalHoursInMins = (arrivalHour * 60) + arrivalMinutes;
            if (arrivalHoursInMins > examHoursInMins)
            {
                Console.WriteLine("Late");
                delay = arrivalHoursInMins - examHoursInMins;
                if (delay > 59)
                {
                    Console.WriteLine($"{delay / 60}:{delay % 60:d2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{delay} minutes after the start");
                }
            }
            else if (examHoursInMins - arrivalHoursInMins <= 30)
            {
                Console.WriteLine("On time");
                early = examHoursInMins - arrivalHoursInMins;
                if (early != 0)
                {
                    Console.WriteLine($"{early} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Early");
                early = examHoursInMins - arrivalHoursInMins;
                if (early > 59)
                {
                    Console.WriteLine($"{early / 60}:{early % 60:d2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{early} minutes before the start");
                }
            }

        }
    }
}
