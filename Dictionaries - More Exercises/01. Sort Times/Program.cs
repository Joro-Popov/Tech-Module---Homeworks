using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Times = Console.ReadLine()
                .Split(' ')
                .OrderBy(w => w)
                .ToList();

            Console.WriteLine(string.Join(", ",Times));
        }
    }
}
