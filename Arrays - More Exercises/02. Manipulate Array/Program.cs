using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string command = Console.ReadLine();

                if (command == "Reverse")
                {
                    input.Reverse();
                }
                else if (command == "Distinct")
                {
                    input = input.Distinct().ToList();
                }
                else 
                {
                    List<string> Tokens = command.Split(' ').ToList();

                    int position = int.Parse(Tokens[1]);
                    string replaceWord = Tokens[2];

                    input.RemoveAt(position);
                    input.Insert(position, replaceWord);
                    
                }
            }
            Console.WriteLine(string.Join(", ",input));   
        }
    }
}
