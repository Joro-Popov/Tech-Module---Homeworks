using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("Input.txt");

            input = input
                .Where((line, i) => i % 2 == 1)
                .ToArray();

            File.WriteAllLines("Output.txt", input);
            
        }
    }
}
