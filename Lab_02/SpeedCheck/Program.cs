using System;

namespace SpeedCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            double speedNum = double.Parse(Console.ReadLine());
            if (speedNum <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (speedNum > 10 && speedNum <= 50)
            {
                Console.WriteLine("average");
            }
            else if (speedNum > 50 && speedNum <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (speedNum > 150 && speedNum <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else 
            {
                Console.WriteLine("extremely fast");
            }

        }
    }
}
