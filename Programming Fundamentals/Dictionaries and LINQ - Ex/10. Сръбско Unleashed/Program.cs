using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> Venues =
            new Dictionary<string, Dictionary<string, int>>();

            string Input = Console.ReadLine();

            while (Input != "End")
            {
                Regex InputPattern = new Regex(@"(?'singer'([A-z]+\s*){1,3}\s+)@(?'venue'([A-z]+\s*){1,3}\s)(?'ticketPrice'\d+)\s(?'ticketCount'\d+)");

                Match match = InputPattern.Match(Input);

                if (match.Success)
                {
                    string singer = match.Groups["singer"].ToString();
                    string venue = match.Groups["venue"].ToString();
                    int ticketPrice = int.Parse(match.Groups["ticketPrice"].ToString());
                    int ticketCount = int.Parse(match.Groups["ticketCount"].ToString());

                    int totalAmount = ticketCount * ticketPrice;

                    if (!Venues.ContainsKey(venue))
                    {
                        Venues[venue] = new Dictionary<string, int>();
                    }
                    if (!Venues[venue].ContainsKey(singer))
                    {
                        Venues[venue][singer] = 0;
                    }
                    Venues[venue][singer] += totalAmount;
                }

                Input = Console.ReadLine();
            }

            foreach (var ven in Venues)
            {
                string venue = ven.Key;
                Dictionary<string, int> Singers = ven.Value;

                Console.WriteLine($"{venue}");

                foreach (var sngr in Singers.OrderByDescending(w => w.Value))
                {
                    string singer = sngr.Key;
                    int totalAmount = sngr.Value;

                    Console.WriteLine($"#  {singer}-> {totalAmount}");
                }
            }
        }
    }
}
