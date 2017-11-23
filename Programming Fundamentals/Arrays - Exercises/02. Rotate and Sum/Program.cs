using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int rotations = int.Parse(Console.ReadLine());

            int[] Sum = new int[input.Count];

            //Rotate the array
            for (int i = 0; i < rotations; i++)
            {
                int temp = input[input.Count - 1];
                input.RemoveAt(input.Count - 1);
                input.Insert(0, temp);

                for (int j = 0; j < Sum.Length; j++)
                {
                    Sum[j] = Sum[j] + input[j];
                }
            }

            Console.WriteLine(string.Join(" ",Sum));
        }
    }
}
