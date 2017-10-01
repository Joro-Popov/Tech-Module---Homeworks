using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool special = false;

            for (int i = 1; i <= num; i++)
            {
                int first = i / 10;
                int second = i % 10;
                int sum = first + second;

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    special = true;
                }
                else
                {
                    special = false;
                }

                Console.WriteLine($"{i} -> {special}");
            }
        }
    }
}
