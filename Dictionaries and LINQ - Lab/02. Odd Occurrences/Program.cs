using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> OddOccurences = new Dictionary<string, int>();

            List<string> Input = Console.ReadLine().Split(' ').Select(w => w.ToLower()).ToList();

            foreach (var item in Input)
            {
                if (!OddOccurences.ContainsKey(item))
                {
                    OddOccurences[item] = 0;
                }
                OddOccurences[item]++;
            }

            OddOccurences = OddOccurences
                .Where(w => w.Value % 2 == 1)
                .ToDictionary(p => p.Key, p => p.Value);

            Console.WriteLine(string.Join(", ",OddOccurences.Keys));
        }
    }
}
