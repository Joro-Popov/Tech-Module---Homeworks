using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();

            Regex NumPattern = new Regex(@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");
            MatchCollection matches = NumPattern.Matches(numbers);

            foreach (Match num in matches)
            {
                Console.Write($"{num.Value} ");
            }
            Console.WriteLine();
        }
    }
}
