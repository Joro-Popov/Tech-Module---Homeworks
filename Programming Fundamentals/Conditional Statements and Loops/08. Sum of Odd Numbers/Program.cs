using System;

namespace _08._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            int sum = 0;
            int cnt = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    sum += i;
                    cnt++;
                }
                if (cnt >= n)
                {
                    break;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
