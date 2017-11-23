using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> symbols = Console.ReadLine().Split(' ').ToList();

            symbols.Reverse();

            Console.WriteLine(string.Join(" ",symbols));
        }
    }
}
