using System;

namespace Commisions
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            double volumeSales = double.Parse(Console.ReadLine());

            double commisions = 0.0;

            switch (townName)
            {
                case "Sofia":
                    if (volumeSales >= 0 && volumeSales <= 500)
                    {
                        commisions = volumeSales * 0.05;
                        Console.WriteLine($"{commisions:f2}");
                    }
                    else if (volumeSales > 500 && volumeSales <= 1000)
                    {
                        commisions = volumeSales * 0.07;
                        Console.WriteLine($"{commisions:f2}");
                    }
                    else if (volumeSales > 1000 && volumeSales <= 10000)
                    {
                        commisions = volumeSales * 0.08;
                        Console.WriteLine($"{commisions:f2}");
                    }
                    else if (volumeSales > 10000)
                    {
                        commisions = volumeSales * 0.12;
                        Console.WriteLine($"{commisions:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (volumeSales >= 0 && volumeSales <= 500)
                    {
                        commisions = volumeSales * 0.045;
                        Console.WriteLine($"{commisions:f2}");
                    }
                    else if (volumeSales > 500 && volumeSales <= 1000)
                    {
                        commisions = volumeSales * 0.075;
                        Console.WriteLine($"{commisions:f2}");
                    }
                    else if (volumeSales > 1000 && volumeSales <= 10000)
                    {
                        commisions = volumeSales * 0.10;
                        Console.WriteLine($"{commisions:f2}");
                    }
                    else if (volumeSales > 10000)
                    {
                        commisions = volumeSales * 0.13;
                        Console.WriteLine($"{commisions:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (volumeSales >= 0 && volumeSales <= 500)
                    {
                        commisions = volumeSales * 0.055;
                        Console.WriteLine($"{commisions:f2}");
                    }
                    else if (volumeSales > 500 && volumeSales <= 1000)
                    {
                        commisions = volumeSales * 0.08;
                        Console.WriteLine($"{commisions:f2}");
                    }
                    else if (volumeSales > 1000 && volumeSales <= 10000)
                    {
                        commisions = volumeSales * 0.12;
                        Console.WriteLine($"{commisions:f2}");
                    }
                    else if (volumeSales > 10000)
                    {
                        commisions = volumeSales * 0.145;
                        Console.WriteLine($"{commisions:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}