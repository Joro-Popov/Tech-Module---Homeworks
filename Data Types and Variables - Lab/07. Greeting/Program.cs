using System;

namespace _07._Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {firstName} {secondName}. You are {age} years old.");
        }
    }
}
