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
        static string ConvertFromBase(string baseN, string number)
        {
            char[] basedNum = number.ToCharArray();
            List<char> basedNumber = basedNum.ToList();

            basedNumber.Reverse();

            BigInteger sum = 0;
            BigInteger baseNum = BigInteger.Parse(baseN);

            for (int i = 0; i <= basedNumber.Count-1; i++)
            {
                BigInteger currentNum = BigInteger.Parse(basedNumber[i].ToString());
                BigInteger poweredNum = (BigInteger)(Math.Pow((double)baseNum, i));

                BigInteger result = currentNum * poweredNum;

                sum += result;
                
            }
          
            return sum.ToString();
        }
        static void Main(string[] args)
        {
            List<string> Input = Console.ReadLine().Split(' ').ToList();

            string baseN = Input[0];
            string numberToConvert = Input[1];

            string converted = ConvertFromBase(baseN, numberToConvert);

            Console.WriteLine(converted);
        }
    }
}
