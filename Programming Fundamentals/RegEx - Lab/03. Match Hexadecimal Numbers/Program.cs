using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexNums = Console.ReadLine();
            Regex pattern = new Regex(@"\b(0x)*(\d|[A-F])+\b");

            MatchCollection ValidHex = pattern.Matches(hexNums);

            foreach (Match hex in ValidHex)
            {
                Console.Write($"{hex.Value} ");
            }
            Console.WriteLine();
        }
    }
}
