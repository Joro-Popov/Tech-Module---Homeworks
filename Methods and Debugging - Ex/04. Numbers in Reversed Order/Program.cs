using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void ReverseNumber(string input)
        {
            string reversed = string.Empty;

            for (int i = input.Length-1; i >= 0; i--)
            {
                reversed += input[i];
            }

            Console.WriteLine(reversed);
        }
        static void Main(string[] args)
        {
            ReverseNumber(Console.ReadLine());
        }
    }
}
