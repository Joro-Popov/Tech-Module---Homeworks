using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03.Big_Factorial
{
    class Program
    {
        static BigInteger CalculateFactorial(int num)
        {
            BigInteger factorial = 1;

            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger factorial = CalculateFactorial(num);

            Console.WriteLine(factorial);
        }
    }
}
