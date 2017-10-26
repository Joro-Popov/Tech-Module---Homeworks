using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Banwords = Console.ReadLine()
                .Split(new string[] { ", " },
                StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();

            string Text = Console.ReadLine();

            foreach (var BanWord in Banwords)
            {
                int index = Text.IndexOf(BanWord);
                string replacement = new string('*', BanWord.Length);

                Text = Text.Replace(BanWord, replacement);
            }

            Console.WriteLine(Text);
        }
    }
}
