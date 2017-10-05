using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            if (numbers.Count == 1)
            {
                Console.WriteLine($@"{{ {numbers[0]} }}");
            }
            else if (numbers.Count % 2 == 0)
            {
                Console.WriteLine($"{{ {numbers[(numbers.Count/2)-1]}, {numbers[numbers.Count/2]} }}");
            }
            else
            {
                Console.WriteLine($"{{ {numbers[(numbers.Count/2)-1]}, {numbers[numbers.Count/2]}, {numbers[(numbers.Count/2)+1]} }}");
            }
        }
    }
}
