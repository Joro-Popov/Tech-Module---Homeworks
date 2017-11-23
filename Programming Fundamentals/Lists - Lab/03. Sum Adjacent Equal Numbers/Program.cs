using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> Numbers = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();

            for (int i = 0; i < Numbers.Count-1;)
            {
                decimal sum = 0;

                if (Numbers[i] == Numbers[i+1])
                {
                    sum = Numbers[i] + Numbers[i + 1];
                    Numbers.RemoveRange(Numbers.IndexOf(Numbers[i]), 2);
                    Numbers.Insert(i, sum);
                    i = 0;
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine(string.Join(" ",Numbers));
        }
    }
}
