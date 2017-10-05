using System;

namespace _02._Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] reversedNumbers = new int[num];

            for (int i = 0; i < num; i++)
            {
                int number = int.Parse(Console.ReadLine());
                reversedNumbers[i] = number;
            }

            for (int i = 0; i < reversedNumbers.Length/2; i++)
            {
                int temp = reversedNumbers[i];
                reversedNumbers[i] = reversedNumbers[reversedNumbers.Length - 1 - i];
                reversedNumbers[reversedNumbers.Length - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ",reversedNumbers));
        }
    }
}
