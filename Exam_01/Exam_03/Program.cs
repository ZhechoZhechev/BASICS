using System;

namespace Exam_03
{
    class Program
    {
        static void Main()
        {
            string contractDuration = Console.ReadLine();
            string contractType = Console.ReadLine();
            string internet = Console.ReadLine();
            int contractInMonths = int.Parse(Console.ReadLine());
            double price = 0;
            if (contractDuration == "one")
            {
                if (contractType == "Small")
                {
                    price = 9.98;
                }
                else if (contractType == "Middle")
                {
                    price = 18.99;
                }
                else if (contractType == "Large")
                {
                    price = 25.98;
                }
                else
                {
                    price = 35.99;
                }
            }
            else if (contractDuration == "two")
            {
                if (contractType == "Small")
                {
                    price = 8.58;
                }
                else if (contractType == "Middle")
                {
                    price = 17.09;
                }
                else if (contractType == "Large")
                {
                    price = 23.59;
                }
                else
                {
                    price = 31.79;
                }
            }
            if (internet == "yes")
            {
                if (price <= 10)
                {
                    price += 5.50;
                }
                else if (price <= 30)
                {
                    price += 4.35;
                }
                else
                {
                    price += 3.85;
                }
            }
            if (contractDuration == "two")
            {
                price *= 0.9625;
            }

            double totalPrice = price * contractInMonths;
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
