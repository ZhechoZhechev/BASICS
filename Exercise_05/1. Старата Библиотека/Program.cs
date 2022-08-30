using System;

namespace _1._Старата_Библиотека
{
    class Program
    {
        static void Main()
        {
            string bookName = Console.ReadLine();
            int bookcounter = 0;

            while (true)
            {
               string command = Console.ReadLine();

                if (command == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {bookcounter} books.");
                }
                else if (command == bookName)
                {
                    Console.WriteLine($"You checked {bookcounter} books and found it.");
                }
                bookcounter++;
            }
        }
    }
}
