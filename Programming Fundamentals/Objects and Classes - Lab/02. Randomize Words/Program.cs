using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Words = Console.ReadLine().Split(' ').ToList();
            Random rnd = new Random();

            for (int i = 0; i < Words.Count; i++)
            {
                int pos2 = rnd.Next(0, Words.Count - 1);
                string temp = Words[i];
                Words[i] = Words[pos2];
                Words[pos2] = temp;
            }

            Console.WriteLine(string.Join("\r\n", Words));
        }
    }
}
