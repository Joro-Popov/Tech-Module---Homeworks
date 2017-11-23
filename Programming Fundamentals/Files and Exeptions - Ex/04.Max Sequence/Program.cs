using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Max_Sequence
{
    class Program
    {
        static List<int> GetMaxSequence(List<int> Elements)
        {
            List<int> CurrentSequence = new List<int>();
            List<int> MaxSequence = new List<int>();

            CurrentSequence.Add(Elements[0]);

            for (int i = 1; i <= Elements.Count - 1; i++)
            {
                if (Elements[i] == CurrentSequence[0])
                {
                    CurrentSequence.Add(Elements[i]);
                }
                else
                {
                    if (CurrentSequence.Count > MaxSequence.Count)
                    {
                        MaxSequence = CurrentSequence;

                    }
                    CurrentSequence = new List<int>();
                    CurrentSequence.Add(Elements[i]);
                }
            }

            return MaxSequence;
        }
        static void Main(string[] args)
        {
            string input = File.ReadAllText("Input.txt");

            List<int> Elements = input
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> MaxSequence = GetMaxSequence(Elements);

            File.WriteAllText("Output.txt", string.Join(" ", MaxSequence));
        }
    }
}
