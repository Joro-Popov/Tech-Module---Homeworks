using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grab_and_Go
{
    class Program
    {
        static void PrintSum(List<int> numbers, int searchNumber)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber == searchNumber)
                {
                    numbers.RemoveRange(0, i+1);
                    break;
                }
            }

            Console.WriteLine(numbers.Sum());
        }

        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int searchNumber = int.Parse(Console.ReadLine());

            numbers.Reverse();

            if (numbers.Contains(searchNumber))
            {
                PrintSum(numbers, searchNumber);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }

        
    }
}
