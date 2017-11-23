using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> input1 = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToList();

            List<char> input2 = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToList();

            string str1 = string.Join("", input1);
            string str2 = string.Join("", input2);

            List<string> Result = new List<string>();

            Result.Add(str1);
            Result.Add(str2);

            Result = Result
                .OrderBy(w => w)
                .ThenBy(w => w.Length)
                .ToList();

            foreach (var str in Result)
            {
                Console.WriteLine(str);
            }
        }
    }
}
