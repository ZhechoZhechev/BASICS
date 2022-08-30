using System;

namespace PassCheck
{
    class PassCheck
    {
        static void Main()
        {
            string userName = Console.ReadLine();
            string passWord = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == passWord)
                {
                    Console.WriteLine($"Welcome {userName} !");
                    break;
                }
            }
        }

    }
}
