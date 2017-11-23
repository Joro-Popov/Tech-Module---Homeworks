using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string dates = Console.ReadLine();
            Regex DatePattern = new Regex(@"(?<day>\d{2})(\.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})");

            MatchCollection Dates = DatePattern.Matches(dates);

            foreach (Match date in Dates)
            {
                string day = date.Groups["day"].ToString();
                string month = date.Groups["month"].ToString();
                string year = date.Groups["year"].ToString();

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
