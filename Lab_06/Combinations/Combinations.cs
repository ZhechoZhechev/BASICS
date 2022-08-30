using System;

namespace Combinations
{
    class Combinations
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int combinationsCounter = 0;
            for (int x = 0; x <= num; x++)
            {
                for (int y = 0; y <= num; y++)
                {
                    for (int z = 0; z <= num; z++)
                    {
                        if (x+y+z == num)
                        {
                            combinationsCounter++;
                        }
                    }
                }
            }
            Console.WriteLine(combinationsCounter);
        }
    }
}
