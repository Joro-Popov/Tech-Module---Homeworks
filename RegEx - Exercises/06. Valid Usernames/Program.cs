using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
    class Words
    {
        public string Word1 { get; set; }
        public string Word2 { get; set; }
        public int TotalLength { get; set; }

        public Words(string w1, string w2)
        {
            Word1 = w1;
            Word2 = w2;
            TotalLength = Word1.Length + Word2.Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string listUsernames = Console.ReadLine();
            string splitPattern = @"\/+|\s+|\(+|\)+|\\+";
            string validUserPattern = @"\b[A-z]\w{3,25}\b";

            Regex UserPattern = new Regex(validUserPattern);

            List<string> Usernames = Regex.Split(listUsernames, splitPattern)
                .Where(w => w != string.Empty)
                .Where(w => UserPattern.IsMatch(w))
                .ToList();

            List<Words> AllWords = new List<Words>();

            for (int i = 0; i < Usernames.Count-1; i++)
            {
                string w1 = Usernames[i];
                string w2 = Usernames[i+1];

                Words currentWords = new Words(w1, w2);
                AllWords.Add(currentWords);
            }

            AllWords = AllWords
                 .OrderByDescending(w => w.TotalLength)
                 .Take(1)
                 .ToList();

            Words Biggest = AllWords[0];

            Console.WriteLine($"{Biggest.Word1}\r\n{Biggest.Word2}");
        }
    }
}
