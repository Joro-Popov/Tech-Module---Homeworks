using System;

namespace _09._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            
            bool special = false;

            for (int i = 1; i <= num; i++)
            {
                int currentNum = i;

                sum += i % 10;
                sum += i / 10;

                if (sum == 5|| sum == 7 || sum == 11)
                {
                    special = true;
                }
                else
                {
                    special = false;
                }
                
                Console.WriteLine($"{currentNum} -> {special}");

                sum = 0;
            }

        }
    }
}
