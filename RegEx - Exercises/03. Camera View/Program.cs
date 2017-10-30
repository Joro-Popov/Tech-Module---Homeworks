using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string text = Console.ReadLine();

            int skipElements = numbers[0];
            int takeElements = numbers[1];

            Regex pattern = new Regex(@"(?<=\|<)[^\|<]+");
            MatchCollection words = pattern.Matches(text);

            List<string> pictures = words
                .Cast<Match>()
                .Select(w => w.Value)
                .Select(w => w.Skip(skipElements).Take(takeElements))
                .Select(w => string.Join("", w))
                .ToList();
                

            Console.WriteLine(string.Join(", ",pictures));
        }
    }
}
