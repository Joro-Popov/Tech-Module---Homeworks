using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> Numbers = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .OrderBy(w => w)
                .ToList();

            Console.WriteLine(string.Join(" <= ",Numbers));
        }
    }
}
