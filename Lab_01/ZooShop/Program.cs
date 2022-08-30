using System;

namespace ZooShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int DogFood = int.Parse(Console.ReadLine());
            int CatFood = int.Parse(Console.ReadLine());
            var Sum = (DogFood * 2.50) + (CatFood * 4);
            Console.WriteLine($"{Sum} lv.");
        }
    }
}
 