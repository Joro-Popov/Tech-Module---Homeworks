using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Longest_Increasing_Subsequence
{
    class Program
    {
        static List<int> LongestSubsequence(List<int> InputSequence)
        {
            List<int> LIS = new List<int>();
            int[] len = new int[InputSequence.Count];
            int[] prev = new int[InputSequence.Count];

            if (InputSequence.Count == 0)
            {
                LIS = InputSequence;  
            }
            else
            {
                for (int i = 0; i < InputSequence.Count; i++)
                {
                    int currentNumber = InputSequence[i];

                    if (LIS.Count == 0)
                    {
                        LIS.Add(currentNumber);
                        len[i] = LIS.Count;
                        prev[i] = -1;
                    }
                    else
                    {

                    }
                }
            }
            return LIS;
        }
        static void Main(string[] args)
        {
            List<int> InputSequence = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> LIS = LongestSubsequence(InputSequence);

            Console.WriteLine(string.Join(" ",LIS));
        }
    }
}
