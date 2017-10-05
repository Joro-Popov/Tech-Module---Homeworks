using System;

namespace _03._Printing_Triangle
{
    class Program
    {
        static void FirstHalf(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
        static void SecondHalf(int num)
        {
            for (int i = num-1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            FirstHalf(num);
            SecondHalf(num);
        }
    }
}
