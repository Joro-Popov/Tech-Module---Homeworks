using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex EmailPattern = new Regex(@" ((?<=\s)[a-zA-Z0-9]+([-.]\w*)*@[a-zA-Z]+?([.-][a-zA-Z]*)*(\.[a-z]{2,}))");

            MatchCollection MatchedEmails = EmailPattern.Matches(text);

            foreach (Match match in MatchedEmails)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
