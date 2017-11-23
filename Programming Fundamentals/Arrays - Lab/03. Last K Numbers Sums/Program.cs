using System;

namespace _03._Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] numbers = new long[n];
            numbers[0] = 1;


            for (long i = 1; i < n; i++)
            {
                if (i < k)
                {
                    long sum = 0;

                    for (int j = 0; j <= i-1; j++)
                    {
                        sum += numbers[j];
                    }
                    numbers[i] = sum;
                }
                else 
                {
                    long sum = 0;

                    for (long j = i-k; j <= i-1; j++)
                    {
                        sum += numbers[j];
                    }
                    numbers[i] = sum;
                }
               
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
