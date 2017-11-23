using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, ushort> NumbersCount = 
            new Dictionary<string, ushort>();

            List<string> InputNumbers = File.ReadAllText("Input.txt")
                .Split(' ')
                .ToList();

            foreach (var num in InputNumbers)
            {
                if (!NumbersCount.ContainsKey(num))
                {
                    NumbersCount[num] = 0;
                }
                NumbersCount[num]++;
            }

            NumbersCount = NumbersCount
                .OrderByDescending(w => w.Value)
                .Take(1)
                .ToDictionary(p => p.Key, p => p.Value);

            string result = string.Join("", NumbersCount.Keys);

            File.WriteAllText("Output.txt", result);
        }
    }
}
