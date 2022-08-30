using System;

namespace zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = Console.ReadLine();
            string LastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine($"You are {FirstName} {LastName}, a {age}-years old person from {town}.");
        }
    }
}
