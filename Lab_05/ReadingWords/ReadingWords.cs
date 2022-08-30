using System;

namespace ReadingWords
{
    class ReadingWords
    {
        static void Main()
        {
            string word = string.Empty;
            while ((word = Console.ReadLine()) != "Stop")
            {
                Console.WriteLine(word);
            }

        }
    }
}