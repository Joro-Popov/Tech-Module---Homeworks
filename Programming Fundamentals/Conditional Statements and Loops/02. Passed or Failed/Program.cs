using System;

namespace _02._Passed_or_Failed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal grade = decimal.Parse(Console.ReadLine());

            if (grade >= 3.00m)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
