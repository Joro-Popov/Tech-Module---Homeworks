using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> CurrentSequence = new List<int>();
            List<int> MaxSequence = new List<int>();

            CurrentSequence.Add(Input[0]);

            for (int i = 1; i <= Input.Count - 1; i++)
            {
                if (Input[i]-1 == CurrentSequence[CurrentSequence.Count-1])
                {
                    CurrentSequence.Add(Input[i]);
                }
                else
                {
                    if (CurrentSequence.Count > MaxSequence.Count)
                    {
                        MaxSequence = CurrentSequence;

                    }
                    CurrentSequence = new List<int>();
                    CurrentSequence.Add(Input[i]);
                }
            }

            if (CurrentSequence.Count > MaxSequence.Count)
            {
                Console.WriteLine(string.Join(" ", CurrentSequence));
            }
            else
            {
                Console.WriteLine(string.Join(" ", MaxSequence));
            }
        }
    }
}
