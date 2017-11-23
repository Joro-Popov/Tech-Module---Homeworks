using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static string Concatenate(string text, string start, string end)
        {
            string result = string.Empty;

            Regex TextPattern = new Regex($@"(?<={start}).*?(?={end})");
            MatchCollection matches = TextPattern.Matches(text);

            foreach (Match word in matches)
            {
                result += word.Value;
            }

            if (result.Length == 0)
            {
                result = "Empty result";
            }

            return result;
        }
        static void Main(string[] args)
        {
            string keyString = Console.ReadLine();
            string text = Console.ReadLine();

            Regex KeysPattern = 
            new Regex(@"(?<start>^[A-z]+?(?=[\|<\\])).*(?<=[\|<\\])(?<end>[A-z]+)");
            Match StartEnd = KeysPattern.Match(keyString);

            string start = StartEnd.Groups["start"].ToString();
            string end = StartEnd.Groups["end"].ToString();
            string result = Concatenate(text, start, end);

            Console.WriteLine(result);
        }
    }
}
