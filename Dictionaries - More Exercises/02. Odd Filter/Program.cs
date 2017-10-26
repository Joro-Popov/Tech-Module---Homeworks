using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .ToList();

            List<int> OddNumbers = new List<int>();

            for (int i = 0; i < Numbers.Count; i++)
            {
                int currentNum = Numbers[i];

                if (currentNum > Numbers.Average())
                {
                    currentNum++;
                }
                else
                {
                    currentNum--;
                }

                OddNumbers.Add(currentNum);
            }

            Console.WriteLine(string.Join(" ",OddNumbers));
        }
    }
}
