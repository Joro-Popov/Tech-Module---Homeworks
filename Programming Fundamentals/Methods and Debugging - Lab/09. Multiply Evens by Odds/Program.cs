using System;

namespace _09._Multiply_Evens_by_Odds
{
    class Program
    {
        static int sum(string num)
        {
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (char.IsDigit(num[i]))
                {
                    int current = Math.Abs(num[i]) - 48;

                    if (current % 2 == 0)
                    {
                        sumEven += current;

                    }
                    else
                    {
                        sumOdd += current;
                    }
                }
            }

            int totalSum = sumEven * sumOdd;

            return totalSum;
        }
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            Console.WriteLine(sum(num));
        }
    }
}
