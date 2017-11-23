using System;

namespace _13._Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;

            for (int i = N; i <= M; i++)
            {
                for (int j = N; j <= M; j++)
                {
                    combinations++;

                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magicNumber}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
        }
    }
}
