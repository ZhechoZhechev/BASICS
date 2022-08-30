using System;

namespace NumsNto1
{
    class NumsNtoOne
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i--)
                Console.WriteLine(i);
        }
    }
}
