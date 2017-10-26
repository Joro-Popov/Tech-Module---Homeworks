using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static long GetCharCodeSum(string str1, string str2)
        {
            long sum = 0;

            int str1Length = str1.Length;
            int str2Length = str2.Length;

            if (str1Length.CompareTo(str2Length) == -1)
            {
                for (int i = 0; i < str2Length; i++)
                {
                    int token1 = str2[i];
                    int token2;
                    try
                    {
                        token2 = str1[i];

                        sum += (token1 * token2);
                    }
                    catch (Exception)
                    {
                        sum += token1;
                    }

                }
            }
            else
            {
                for (int i = 0; i < str1Length; i++)
                {
                    int token1 = str1[i];
                    int token2;
                    try
                    {
                        token2 = str2[i];

                        sum += (token1 * token2);
                    }
                    catch (Exception)
                    {
                        sum += token1;
                    }
                }
            }

            return sum;
        }
        static void Main(string[] args)
        {
            List<string> Input = Console.ReadLine().Split(' ').ToList();

            string str1 = Input[0];
            string str2 = Input[1];

            long TotalSum = GetCharCodeSum(str1, str2);

            Console.WriteLine(TotalSum);
        }
    }
}
