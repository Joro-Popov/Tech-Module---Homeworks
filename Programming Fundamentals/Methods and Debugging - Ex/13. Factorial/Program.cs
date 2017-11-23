using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void PrintFactoriel(int num)
        {
            BigInteger factoriel = 1;

            for (int i = 1; i <= num; i++)
            {
                factoriel *= i;
            }

            Console.WriteLine(factoriel);
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintFactoriel(num);
        }
    }
}
