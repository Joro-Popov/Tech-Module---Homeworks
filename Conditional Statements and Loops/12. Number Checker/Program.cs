using System;

namespace _12._Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);
                Console.WriteLine($"It is a number.");
            }
            catch (Exception)
            {

                Console.WriteLine($"Invalid input!");
            }
        }
    }
}
