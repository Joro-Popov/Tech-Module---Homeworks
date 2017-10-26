using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Min__Max__Sum__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<int> Numbers = new List<int>();
            
            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                Numbers.Add(num);
            }

            Console.WriteLine($"Sum = {Numbers.Sum()}");
            Console.WriteLine($"Min = {Numbers.Min()}");
            Console.WriteLine($"Max = {Numbers.Max()}");
            Console.WriteLine($"Average = {Numbers.Average()}");
        }
    }
}
