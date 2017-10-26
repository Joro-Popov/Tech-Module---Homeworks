using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static bool IsPalindrome(string word)
        {
            bool palindrome = true;

            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] != word[word.Length-1-i])
                {
                    palindrome = false;
                    break;
                }
            }
            return palindrome;
        }
        static void Main(string[] args)
        {
            List<string> Input = Console.ReadLine()
                .Split(new char[] { ' ', ',', '.', '?', '!' },
                StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();

            HashSet<string> Palindromes = new HashSet<string>();

            foreach (var word in Input)
            {
                if (IsPalindrome(word))
                {
                    Palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ",Palindromes.OrderBy(w => w)));
        }
    }
}
