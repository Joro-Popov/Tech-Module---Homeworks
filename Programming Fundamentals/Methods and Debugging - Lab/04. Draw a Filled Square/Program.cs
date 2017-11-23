using System;

namespace _04._Draw_a_Filled_Square
{
    class Program
    {
        static void header(int num)
        {
            Console.WriteLine($"{new string('-',2*num)}");
        }
        static void middle(int num)
        {
            for (int i = 0; i < num-2; i++)
            {
                Console.Write("-");

                for (int j = 0; j < num-1; j++)
                {
                    Console.Write($"\\/");
                }
                Console.WriteLine("-");
            }
        }
        static void printSquare(int num)
        {
            header(num);
            middle(num);
            header(num);
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            printSquare(num);
        }
    }
}
