using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            List<string> command = Console.ReadLine().Split(' ').ToList();

            while (command[0] != "END")
            {
                if (command[0] == "Reverse")
                {
                    input.Reverse();
                }
                else if (command[0] == "Distinct")
                {
                    input = input.Distinct().ToList();
                }
                else if (command[0] == "Replace")
                {
                    int index = int.Parse(command[1]);
                    string replaceWord = command[2];

                    if (index <= input.Count-1 && index >= 0)
                    {
                        input.RemoveAt(index);
                        input.Insert(index, replaceWord);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(string.Join(", ",input));
        }
    }
}
