using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> Alphabet = new List<char>()
            {
                                                                                                    'a','b','c','d','e','f','g',
                 'h','i','j','k','l','m', 'n',
                'o','p','q','r','s','t','u','v','w','x','y','z'
            };

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (Alphabet.Contains(input[i]))
                {
                    Console.WriteLine($"{input[i]} -> {Alphabet.IndexOf(input[i])}");
                }
            }
        }
    }
}
