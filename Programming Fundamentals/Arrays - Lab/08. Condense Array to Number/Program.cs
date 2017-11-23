using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static int Condense(List<int> numbers)
        {
            int result = 0;

            while (numbers.Count != 1)
            {
                List<int> temp = new List<int>();

                for (int i = 0; i < numbers.Count-1; i++)
                {
                    int sum = numbers[i] + numbers[i + 1];
                    temp.Add(sum);
                }
                numbers = temp;
                
            }
            result = numbers[0];
            return result;
        }
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            if (numbers.Count == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                Console.WriteLine(Condense(numbers));
            }
        }
    }
}
