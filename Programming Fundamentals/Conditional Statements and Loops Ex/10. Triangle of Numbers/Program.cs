using System;

namespace _10._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.Write(i);
                for (int j = 0; j < i-1; j++)
                {
                    Console.Write($" {i}");
                }
                Console.WriteLine();
            }
        }
    }
}
