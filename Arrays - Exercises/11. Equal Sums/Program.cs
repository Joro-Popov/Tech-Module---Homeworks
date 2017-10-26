using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static int GetLeftSum(int i,List<int> input)
        {
            int sum = 0;

            for (int j = 0; j < i; j++)
            {
                sum += input[j];
            }
            return sum;
        }
        static int GetRightSum(int i, List<int> input)
        {
            int sum = 0;

            for (int j = i+1; j < input.Count; j++)
            {
                sum += input[j];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int index = 0;
            bool IsFound = false;

            if (input.Count == 1)
            {
                Console.WriteLine("0");
            }
            else
            {
                for (int i = 0; i < input.Count; i++)
                {
                    int leftSum = GetLeftSum(i, input);
                    int rightSum = GetRightSum(i, input);

                    if (leftSum == rightSum)
                    {
                        index = i;
                        IsFound = true;
                        break;
                    }
                }

                if (!IsFound)
                {
                    Console.WriteLine("no");
                }
                else
                {
                    Console.WriteLine(index);
                }
            }
            
        }
    }
}
