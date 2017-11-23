using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> WordCounts = new Dictionary<string, int>();

            List<string> Words = File.ReadAllText("words.txt")
                .Split(' ')
                .Select(w => w.ToLower())
                .ToList();

            List<string> Input = File.ReadAllText("Input.txt")
                .Split(new char[] { '-', ' ', ',', '.', '\n','\r', '?', '!' },
                StringSplitOptions
                .RemoveEmptyEntries)
                .Select(w => w.ToLower())
                .ToList();

            foreach (var word in Words)
            {
                WordCounts[word] = 0;
            }

            foreach (var word in Input)
            {
                if (WordCounts.ContainsKey(word))
                {
                    WordCounts[word]++;
                }
            }

            using (StreamWriter writer = new StreamWriter("Output.txt",true))
            {
                foreach (var word in WordCounts.OrderByDescending(w => w.Value))
                {
                    string result = ($"{word.Key} - {word.Value}");

                    writer.WriteLine(result);
                }
            }
        }
    }
}
