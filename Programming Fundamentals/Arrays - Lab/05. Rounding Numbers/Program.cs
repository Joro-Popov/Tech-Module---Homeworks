using System;
using System.Linq;

namespace _05._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double result = Math.Round(numbers[i], 0, MidpointRounding.AwayFromZero);

                Console.WriteLine($"{numbers[i]} => {result}");
            }
        }
    }
}
