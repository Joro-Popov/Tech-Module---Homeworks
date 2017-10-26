using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<ushort, ushort> repeats = new Dictionary<ushort, ushort>();

            List<ushort> input = Console.ReadLine()
                .Split(' ')
                .Select(ushort.Parse)
                .ToList();

            foreach (var num in input)
            {
                if (!repeats.ContainsKey(num))
                {
                    repeats[num] = 0;
                }
                repeats[num]++;
            }

            repeats = repeats
                .OrderByDescending(w => w.Value)
                .Take(1)
                .ToDictionary(p => p.Key, p => p.Value);

            foreach (var num in repeats)
            {
                Console.WriteLine(num.Key);
            }
        }
    }
}
