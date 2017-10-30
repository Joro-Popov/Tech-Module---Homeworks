using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"\+359( |-)(2)\1(\d+){3}\1(\d{4})\b");
            string numbers = Console.ReadLine();

            MatchCollection PhoneNumbers = pattern.Matches(numbers);

            List<string> ExtractedPhoneNumbers = PhoneNumbers
                .Cast<Match>()
                .Select(w => w.Value)
                .ToList();

            Console.WriteLine(string.Join(", ",ExtractedPhoneNumbers));
        }
    }
}
