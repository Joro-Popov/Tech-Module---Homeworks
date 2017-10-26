using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string Text = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            int index = Text.IndexOf(pattern);
            int cnt = 0;

            while (index != -1)
            {
                cnt++;
                index = Text.IndexOf(pattern,index+1);
            }

            Console.WriteLine(cnt);
        }
    }
}
