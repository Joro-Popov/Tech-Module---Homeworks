using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> firstPart = new List<int>();
            List<int> secondPart = new List<int>();
            List<int> foldList = new List<int>();

            int count = input.Count / 4;

            for (int i = 0; i < count; i++)
            {
                firstPart.Add(input[0]);
                secondPart.Add(input[input.Count - 1]);
                input.RemoveAt(input.Count - 1);
                input.RemoveAt(0);
            }

            firstPart.Reverse();

            foldList = firstPart;
            foldList.AddRange(secondPart);

            List<int> Sum = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                Sum.Add(input[i] + foldList[i]);
            }

            Console.WriteLine(string.Join(" ",Sum));
        }
    }
}
