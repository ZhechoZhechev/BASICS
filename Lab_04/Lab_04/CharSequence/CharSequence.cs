using System;

namespace CharSequence
{
    class CharSequence
    {
        static void Main()
        {
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                Console.WriteLine(letter);
            }
        }
    }
}
