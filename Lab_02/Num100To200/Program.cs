using System;

namespace Num100To200
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (100 <= a && a <= 200) 
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if(a > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
