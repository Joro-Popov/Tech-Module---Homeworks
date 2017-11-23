using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static BigInteger GetFactoriel(int num)
        {
            BigInteger factoriel = 1;

            for (int i = 1; i <= num; i++)
            {
                factoriel *= i;
            }

            return factoriel;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger factoriel = GetFactoriel(num);
            int trailingZeros = 0;

            while (factoriel % 10 == 0)
            {
                trailingZeros++;
                factoriel = factoriel / 10;
            }
            Console.WriteLine(trailingZeros);
        }
    }
}
