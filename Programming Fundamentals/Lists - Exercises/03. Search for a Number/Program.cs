using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> Conditions = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int numberOfElementsToTake = Conditions[0];
            int numberOfElementsToDelete = Conditions[1];
            int searchNumber = Conditions[2];

            Numbers = Numbers.Take(numberOfElementsToTake).ToList();
            Numbers.RemoveRange(0, numberOfElementsToDelete);

            if (Numbers.Contains(searchNumber))
            {
                Console.WriteLine($"YES!");
            }
            else
            {
                Console.WriteLine($"NO!");
            }
        }
    }
}
