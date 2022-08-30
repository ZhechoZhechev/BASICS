using System;

namespace RadiantsToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double Radians = double.Parse(Console.ReadLine());
            Double Degrees = Radians * 180 / Math.PI;
            Console.WriteLine(Degrees);

        }
    }
}
