using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int difference = int.Parse(Console.ReadLine());
            int diffCounter = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    int firstNum = numbers[i];
                    int secondNum = numbers[j];

                    int currentDiff = firstNum - secondNum;

                    if (currentDiff == difference)
                    {
                        diffCounter++;
                    }
                }
            }

            Console.WriteLine(diffCounter);
        }
    }
}
