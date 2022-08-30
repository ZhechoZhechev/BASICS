using System;

namespace Exerscise01
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());
            Double BGN = USD * 1.79549;
            Console.WriteLine(BGN);
        }
    }
}
