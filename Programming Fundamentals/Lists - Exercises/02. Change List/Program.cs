using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<string> Command = Console.ReadLine().Split(' ').ToList();

            while (string.Join("",Command) != "Odd" && string.Join("", Command) != "Even")
            {
                if (Command[0] == "Delete")
                {
                    int num = int.Parse(Command[1]);

                    Numbers = Numbers
                        .Where(w => w != num)
                        .ToList();
                }
                else if (Command[0] == "Insert")
                {
                    int element = int.Parse(Command[1]);
                    int position = int.Parse(Command[2]);

                    Numbers.Insert(position, element);
                }

                Command = Console.ReadLine().Split(' ').ToList();
            }

            if (string.Join("",Command) == "Odd")
            {
                Numbers = Numbers
                    .Where(w => w % 2 == 1)
                    .ToList();

                Console.WriteLine(string.Join(" ",Numbers));
            }
            else
            {
                Numbers = Numbers
                    .Where(w => w % 2 == 0)
                    .ToList();

                Console.WriteLine(string.Join(" ",Numbers));
            }
        }
    }
}
