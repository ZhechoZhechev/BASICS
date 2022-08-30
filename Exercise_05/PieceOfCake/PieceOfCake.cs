using System;

namespace PieceOfCake
{
    class PieceOfCake
    {
        static void Main()
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeHeight = int.Parse(Console.ReadLine());
            int cakePiecesCount = cakeHeight * cakeWidth;
            int cackePieces = 0;
            while (cakePiecesCount > 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                cackePieces = int.Parse(input);
                cakePiecesCount -= cackePieces;
            }
            if (cakePiecesCount > 0)
            {
                Console.WriteLine($"{cakePiecesCount} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakePiecesCount)} pieces more.");
            }
        }
    }
}
