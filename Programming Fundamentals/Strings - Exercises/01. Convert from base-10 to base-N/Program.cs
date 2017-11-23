using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Convert_from_base_10_to_base_N
{
    class Program
    {
        static string ConvertToBase(BigInteger baseN, BigInteger number)
        {
            StringBuilder converted = new StringBuilder();

            while (number != 0)
            {
                string token = (number % baseN).ToString();
                converted.Insert(0,token);

                number = number / baseN;
            }

            return converted.ToString();
        }
        static void Main(string[] args)
        {
            List<BigInteger> Input = Console.ReadLine()
                .Split(' ')
                .Select(BigInteger.Parse)
                .ToList();

            BigInteger baseN = Input[0];
            BigInteger numberToConvert = Input[1];

            BigInteger converted = BigInteger.Parse(ConvertToBase(baseN, numberToConvert));

            Console.WriteLine(converted);
        }
    }
}
