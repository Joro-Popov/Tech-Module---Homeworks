using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Where(w => Math.Sqrt(w) == (int)Math.Sqrt(w))
                .OrderByDescending(w => w)
                .ToList();

            Console.WriteLine(string.Join(" ",Numbers));
        }
    }
}
