using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Sum_Arrays
{
    class Program
    {
        static List<int> GetSum(List<int> firstList, List<int> secondList)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < firstList.Count; i++)
            {
                int sum = firstList[i] + secondList[i];
                result.Add(sum);
            }

            return result;
        }

        static void Main(string[] args)
        {
            List<int> result = new List<int>();

            List<int> firstList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            if (firstList.Count == secondList.Count)
            {
                result = GetSum(firstList, secondList);
            }
            else if (firstList.Count < secondList.Count)
            {
                int count = secondList.Count - firstList.Count;

                for (int i = 0; i < count; i++)
                {
                    firstList.Add(firstList[i]);
                }
                result = GetSum(firstList, secondList);
            }
            else
            {
                int count = firstList.Count - secondList.Count;

                for (int i = 0; i < count; i++)
                {
                    secondList.Add(secondList[i]);
                }
                result = GetSum(firstList, secondList);
            }

            Console.WriteLine(string.Join(" ",result));
        }

        
    }
}
