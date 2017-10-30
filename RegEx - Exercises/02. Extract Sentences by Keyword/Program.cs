using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            string text = Console.ReadLine();

            Regex SentencePattern = 
            new Regex($@"[A-Z][^.?!]*\b{keyWord}\b([^.?!]*)");

            MatchCollection Sentences = SentencePattern.Matches(text);

            foreach (Match sentence in Sentences)
            {
                Console.WriteLine(sentence.Value);
            }

        }
    }
}
