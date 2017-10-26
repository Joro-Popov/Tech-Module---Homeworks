using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> CollectedValues = new List<int>();
            CollectedValues.Add(numbers[0]);
            int index = numbers[0];

            bool possible = true;

            while (possible)
            {
                if (index <= (numbers.Count - 1) - (numbers.IndexOf(index)))
                {
                    int position = index + numbers.IndexOf(index);
                    index = numbers[position];
                    CollectedValues.Add(index);
                    
                }
                else if (index <= numbers.IndexOf(index))
                {
                    int position = numbers.LastIndexOf(index) - index;
                    index = numbers[position];
                    CollectedValues.Add(index);

                }
                else
                {
                    possible = false;
                }
            }

            Console.WriteLine(CollectedValues.Sum());
        }
    }
}
