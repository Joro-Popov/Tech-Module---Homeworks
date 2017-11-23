using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> Numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            for (int i = 0; i < Numbers.Count; i++)
            {
                List<char> current = Numbers[i]
                    .ToString()
                    .Split(' ')
                    .Select(char.Parse)
                    .ToList();

                current.Reverse();

                string reversed = string.Join("",current);
                sum += int.Parse(reversed);
            }

            Console.WriteLine(sum);
        }
    }
}
