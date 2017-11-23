using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < num; i++)
            {
                decimal n = decimal.Parse(Console.ReadLine());
                sum += n;
            }

            Console.WriteLine(sum);
        }
    }
}
