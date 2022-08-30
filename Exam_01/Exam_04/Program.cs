using System;

namespace Exam_04
{
    class Program
    {
        static void Main()
        {
            int gamesCount = int.Parse(Console.ReadLine());
            int hearthstoneCounter = 0;
            int forniteCounter = 0;
            int overwatchCounter = 0;
            int othersCounter = 0;


            for (int i = 1; i <= gamesCount; i++)
            {
                string gameName = Console.ReadLine();
                if (gameName == "Hearthstone")
                {
                    hearthstoneCounter++;
                }
                else if (gameName == "Fornite")
                {
                    forniteCounter++;
                }
                else if (gameName == "Overwatch")
                {
                    overwatchCounter++;
                }
                else
                {
                    othersCounter++;
                }
            }
            Console.WriteLine($"Hearthstone - {(hearthstoneCounter / (double)gamesCount) * 100:f2}%");
            Console.WriteLine($"Fornite - {(forniteCounter / (double)gamesCount) * 100:f2}%");
            Console.WriteLine($"Overwatch - {(overwatchCounter / (double)gamesCount) * 100:f2}%");
            Console.WriteLine($"Others - {(othersCounter / (double)gamesCount) * 100:f2}%");
        }
    }
}
