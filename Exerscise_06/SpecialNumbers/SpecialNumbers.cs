using System;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main()
        {
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1111; i <= 9999; i++)
            //{
            //    int copyI = i;
            //    bool iIsspecial = true;
            //    for (int j = 1; j <= 4; j++)
            //    {
            //        int currentDig = copyI % 10;//234.5 = 5
            //        if (currentDig == 0 || num % currentDig != 0)
            //        {
            //            iIsspecial = false;
            //            break;
            //        }
            //        copyI /= 10;

            //    }
            //    if (iIsspecial)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //}
            int num = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int digit = int.Parse(i.ToString().Substring(0,1));
                int digit2 = int.Parse(i.ToString().Substring(1,1));
                int digit3 = int.Parse(i.ToString().Substring(2,1));
                int digit4 = int.Parse(i.ToString().Substring(3,1));
                if (digit * digit2 * digit3 * digit4 == 0)
                {
                    continue;
                }
                if (num % digit == 0 && num % digit2 == 0 && num % digit3 == 0 && num % digit4 == 0)
                {
                    Console.WriteLine("Special number " + i.ToString());
                }
            }
        }

    }
}
