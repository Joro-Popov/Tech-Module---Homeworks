using System;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            bool combinations = true;

            for (int a = begin; a <= end; a++)
            {
                for (int b = begin; b <= end; b++)
                {
                    for (int c = begin; c <= end; c++)
                    {
                        for (int d = begin; d < end; d++)
                        {
                            for (int e = begin; e <= end; e++)
                            {
                                if (a < b && b < c && c < d && d < e)
                                {
                                    combinations = false;
                                    Console.WriteLine($"{a} {b} {c} {d} {e}");
                                }
                            }
                        }
                    }
                }
            }

            if (combinations)
            {
                Console.WriteLine("No");
            }
        }
    }
}
