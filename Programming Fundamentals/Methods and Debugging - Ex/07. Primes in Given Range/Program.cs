using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static bool IsPrime(long num)
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
            List<int> numbers = new List<int>();

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    numbers.Add(i);
                }
            }
            
            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}
