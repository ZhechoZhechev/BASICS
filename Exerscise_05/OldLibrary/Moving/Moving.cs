using System;

namespace Moving
{
    class Moving
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            //One box is with dimensions 1*1*1 =>
            int roomVolume = width * lenght * hight;
            int boxesCount = 0;

            while (roomVolume > 0)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                boxesCount = int.Parse(input);
                roomVolume -= boxesCount;

            }

            if (roomVolume > 0)
            {
                Console.WriteLine($"{roomVolume} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space!" +
                    $" You need {Math.Abs(roomVolume)} Cubic meters more.");
            }

        }
    }
}
