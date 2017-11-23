using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static string GetSum(string input1, string input2)
        {
            StringBuilder result = new StringBuilder();

            if (input1.Length > input2.Length)
            {
                for (int i = 0; i < input1.Length; i++)
                {
                   
                }
            }
            else
            {
                for (int i = 0; i < input2.Length; i++)
                {

                }
            }

            return result.ToString();
        }
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            string result = GetSum(input1, input2);
        }
    }
}
