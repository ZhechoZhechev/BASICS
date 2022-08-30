using System;

namespace NumOperator
{
    class NumOperator
    {
        static void Main()
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            char numOperator = char.Parse(Console.ReadLine());

            double result = 0.0;
            string oddOrEven = null;

            if (numTwo != 0)
            {
                if (numOperator == '+')
                {
                    result = numOne + numTwo;
                    if (result % 2 == 0)
                    {
                        oddOrEven = "even";
                    }
                    else if (result %2 != 0)
                    {
                        oddOrEven = "odd";
                    }
                }
                else if (numOperator == '-')
                {
                    result = numOne - numTwo;
                    if (result % 2 == 0)
                    {
                        oddOrEven = "even";
                    }
                    else if (result % 2 != 0)
                    {
                        oddOrEven = "odd";
                    }
                }
                else if (numOperator == '*')
                {
                    result = numOne * numTwo;
                    if (result % 2 == 0)
                    {
                        oddOrEven = "even";
                    }
                    else if (result % 2 != 0)
                    {
                        oddOrEven = "odd";
                    }
                }
                else if (numOperator == '/')
                {
                    result = numOne / (double)numTwo;
                }
                else if (numOperator == '%')
                {
                    result = numOne % numTwo;
                }
                if (numOperator == '/')
                {
                    Console.WriteLine($"{numOne} {numOperator} {numTwo} = {result:f2}");
                }
                else if (numOperator == '%')
                {
                    Console.WriteLine($"{numOne} % {numTwo} = {result}");
                }
                else
                {
                    Console.WriteLine($"{numOne} {numOperator} {numTwo} = {result} - {oddOrEven}");
                }
            }
            else
            {
                Console.WriteLine($"Cannot divide {numOne} by zero");
            }
        }



        }
    }

