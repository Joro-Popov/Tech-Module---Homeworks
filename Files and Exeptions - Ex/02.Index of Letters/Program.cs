using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> LettersPositions = new Dictionary<char, int>();

            List<char> Alphabet = new List<char>()
                {
                    'a','b','c','d','e','f','g','h','i','j','k','l','m','n',
                    'o','p','q','r','s','t','u','v','w','x','y','z'
                };

            string word = File.ReadAllText("Input.txt");

            foreach (var letter in word)
            {
                LettersPositions[letter] = Alphabet.IndexOf(letter);
            }

            foreach (var letter in LettersPositions)
            {
                string result = ($"{letter.Key} -> {letter.Value}\r\n");
                File.AppendAllText("Output.txt", result);
            }
        }
    }
}
