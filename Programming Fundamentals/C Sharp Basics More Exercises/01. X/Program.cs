using System;

namespace _01._X
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int col = 0; col < N; col++)
            {
                for (int row = 0; row <= N; row++)
                {
                    if (row == col)
                    {
                        Console.Write("x");
                        
                    }
                    if ((N - row) == col)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
