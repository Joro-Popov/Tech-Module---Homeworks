using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = string.Empty;

            while (text != "end")
            {
                Regex pattern = new Regex(@"<a.*?href.*?=(.*)>(.*)<\/a>");
                string replacement = @"[URL href=$1]$2[/URL]";

                string replaced = pattern.Replace(text, replacement);

                result += replaced + "\n";

                text = Console.ReadLine();
            }
            Console.WriteLine(result);
        }
    }
}
