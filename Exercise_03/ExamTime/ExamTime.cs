using System;

namespace ExamTime
{
    class ExamTime
    {
        static void Main()
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            string timeWord = null;
            int delay = 0;
            int early = 0;

            int examInMunutes = (examHour * 60) + examMinutes;
            int arrivalInMinutes = (arrivalHour * 60) + arrivalMinutes;

            if(arrivalInMinutes > examInMunutes)
            {
                timeWord = "Late";
                delay = arrivalInMinutes - examInMunutes;
                if (delay > 59)
                {

                    Console.WriteLine($"{timeWord}");
                    Console.WriteLine($"{delay / 60}:{delay % 60:d2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{timeWord}");
                    Console.WriteLine($"{delay} minutes after the start");
                }
            }
            else if (examInMunutes - arrivalInMinutes <= 30)
            {
                early = examInMunutes - arrivalInMinutes;
                timeWord = "On time";
                if (examHour == arrivalHour && examMinutes == arrivalMinutes)
                {
                    Console.WriteLine($"{timeWord}");
                }
                else if (early < 60)
                {
                    Console.WriteLine($"{timeWord}");
                    Console.WriteLine($"{early} minutes before the start");
                }

            }
            else
            {
                timeWord = "Early";
                early = examInMunutes - arrivalInMinutes;
                if (early < 60)
                {
                    Console.WriteLine($"{timeWord}");
                    Console.WriteLine($"{early} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{timeWord}");
                    Console.WriteLine($"{early / 60}:{early % 60:d2} hours before the start");
                }
            }
        }
    }
}
