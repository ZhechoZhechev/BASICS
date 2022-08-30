using System;

namespace OldLibrary
{
    class OldLibrary
    {
        static void Main()
        {
            string desiredBook = Console.ReadLine();
            int booksCounter = 0;
            string currentBook = Console.ReadLine();
            bool bookIsfound = false;

            while (currentBook != "No More Books")
            {

                if (currentBook == desiredBook)
                {
                    bookIsfound = true;
                    break;
                }
                booksCounter++;
                currentBook = Console.ReadLine();
            }
            if (bookIsfound)
            {
                Console.WriteLine($"You checked {booksCounter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {booksCounter} books.");
            }

        }
    }
}
