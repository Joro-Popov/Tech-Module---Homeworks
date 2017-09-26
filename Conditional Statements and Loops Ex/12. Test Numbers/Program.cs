using System;

namespace _12._Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int Sum = 0;
            int combinations = 0;

            for (int i = N; i >= 1; i--)
            {
                for (int j = 1; j <= M; j++)
                {
                    combinations++;

                    Sum += 3 * (i * j);

                    if (Sum >= maxSum)
                    {
                        Console.WriteLine($"{combinations} combinations");
                        Console.WriteLine($"Sum: {Sum} >= {maxSum}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{combinations} combinations");
            Console.WriteLine($"Sum: {Sum}");
        }
    }
}
