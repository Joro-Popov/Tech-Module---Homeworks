using System;

namespace _02._Sign_of_Integer_Number
{
    class Program
    {
        static void SignofInteger(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else if (num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
        static void Main(string[] args)
        {
            SignofInteger(int.Parse(Console.ReadLine()));
        }
    }
}
