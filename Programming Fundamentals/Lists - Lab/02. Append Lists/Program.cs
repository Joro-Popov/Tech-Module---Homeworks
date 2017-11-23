using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .ToList();

            input.Reverse();

            List<string> Result = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                List<string> tokens = input[i]
                    .Split(new char[] { ' '},
                     StringSplitOptions
                    .RemoveEmptyEntries)
                    .ToList();

                Result.AddRange(tokens);
            }
            Console.WriteLine(string.Join(" ",Result));
        }
    }
}
