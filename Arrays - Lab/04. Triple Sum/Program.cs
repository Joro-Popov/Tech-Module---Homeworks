using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool notCheck = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    int a = numbers[i];
                    int b = numbers[j];
                    int sum = a + b;

                    if (numbers.Contains(sum))
                    {
                        Console.WriteLine($"{a} + {b} == {a + b}");
                        notCheck = false;
                        
                    }
                }
            }
            if (notCheck)
            {
                Console.WriteLine("No");
            }
        }
    }
}
