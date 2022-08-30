using System;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string FigType = Console.ReadLine();
            if (FigType == "square") 
            {
                double a = double.Parse(Console.ReadLine());
                double squareArea = a * a;
                Console.WriteLine($"{squareArea:f3}");
            }
            if(FigType == "rectangle") 
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double rectangleArea = a * b;
                Console.WriteLine($"{rectangleArea:f3}");
            }
            if(FigType == "circle") 
            {
                double r = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * r * r;
                Console.WriteLine($"{circleArea:f3}");
            }
            if (FigType == "triangle") 
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double triangleArea = (a * h) / 2;
                Console.WriteLine($"{triangleArea:f3}");
            }
        }
    }
}
