using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.Equal_Sums
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string Input = File.ReadAllText("Input.txt");

            List<int> Numbers = Input
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            if (Numbers.Count == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 0; i <= Numbers.Count-1; i++)
                {
                    int currentNumber = Numbers[i];

                    List<int> LeftSide = Numbers.GetRange(0, i);
                    List<int> RightSide = Numbers
                        .GetRange(i + 1, (Numbers.Count - 1 - i));

                    if (LeftSide.Sum() == RightSide.Sum())
                    {
                        File.WriteAllText("Output.txt", i.ToString());
                        return;
                    }
                }

                File.WriteAllText("Output.txt", "no");
            }
        }
    }
}
