using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Sieve_of_Eratosthenes
{
    class Program
    {
        static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 2; i <= num; i++)
            {
                numbers.Add(i);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                int n = numbers[i];

                if (IsPrime(n))
                {
                    Console.Write($"{n} ");
                }
            }
            Console.WriteLine();
           
        }
    }
}
