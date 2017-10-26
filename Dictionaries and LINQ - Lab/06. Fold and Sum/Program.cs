using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int k = Numbers.Count / 4;

            List<int> First = Numbers.Take(k).ToList();

            Numbers.RemoveRange(0, k);
            Numbers.Reverse();

            List<int> Second = Numbers.Take(k).ToList();

            Numbers.RemoveRange(0, k);
            Numbers.Reverse();
            First.Reverse();
            First.AddRange(Second);

            List<int> Sum = new List<int>();

            for (int i = 0; i < Numbers.Count; i++)
            {
                int sum = Numbers[i] + First[i];

                Sum.Add(sum);

            }
            Console.WriteLine(string.Join(" ",Sum));
        }
    }
}
