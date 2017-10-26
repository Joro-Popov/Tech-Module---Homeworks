using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> Result = new SortedDictionary<double, int>();

            List<double> Numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            foreach (var num in Numbers)
            {
                if (!Result.ContainsKey(num))
                {
                    Result[num] = 0;
                }
                Result[num]++;
            }

            foreach (var num in Result)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
