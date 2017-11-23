using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> Result = new Dictionary<int, int>();

            List<int> Numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            foreach (var num in Numbers)
            {
                if (!Result.ContainsKey(num))
                {
                    Result[num] = 0;
                }
                Result[num]++;
            }

            foreach (var num in Result.OrderBy(w => w.Key))
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
