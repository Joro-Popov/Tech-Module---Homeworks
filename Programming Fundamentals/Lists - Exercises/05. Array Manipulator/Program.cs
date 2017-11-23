using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulator
{
    class Program
    {
        static List<int> AddMany(List<int> Numbers, List<string> Command)
        {
            int index = int.Parse(Command[1]);
            Command.RemoveRange(0, 2);

            Numbers.InsertRange(index, Command.Select(int.Parse).ToList());

            return Numbers;
        }
        static void ContainsElement(List<int> Numbers, List<string> Command)
        {
            int element = int.Parse(Command[1]);

            if (Numbers.Contains(element))
            {
                Console.WriteLine(Numbers.IndexOf(element));
            }
            else
            {
                Console.WriteLine("-1");
            }
        }

        static List<int> Shift(List<int> Numbers, List<string> Command)
        {
            int count = int.Parse(Command[1]);
            int cnt = 0;

            for (int i = 0; i < count; i++)
            {
                int currentNumber = Numbers[i];

                Numbers.Add(currentNumber);
                Numbers.RemoveAt(Numbers.IndexOf(currentNumber));
                i--;
                cnt++;

                if (cnt == count)
                {
                    break;
                }
            }
            return Numbers;
        }
        static List<int> SumPairs(List<int> Numbers, List<string> Command)
        {
            List<int> Temp = new List<int>();
            int sum = 0;

            for (int i = 0; i < Numbers.Count; i += 2)
            {
                try
                {
                    sum += Numbers[i] + Numbers[i + 1];
                    Temp.Add(sum);
                    sum = 0;
                }
                catch (Exception)
                {
                    Temp.Add(Numbers[Numbers.Count - 1]);
                }

            }

            Numbers = Temp;

            return Numbers;
        }

        static void Main(string[] args)
        {
            List<int> Numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<string> Command = Console.ReadLine().Split(' ').ToList();

            while (string.Join("", Command) != "print")
            {
                if (Command[0] == "add")
                {
                    Numbers.Insert(int.Parse(Command[1]), int.Parse(Command[2]));
                }
                else if (Command[0] == "addMany")
                {
                    Numbers = AddMany(Numbers, Command);
                }
                else if (Command[0] == "contains")
                {
                    ContainsElement(Numbers, Command);
                }
                else if (Command[0] == "remove")
                {
                    Numbers.RemoveAt(int.Parse(Command[1]));
                }
                else if (Command[0] == "shift")
                {
                    Numbers = Shift(Numbers, Command);
                }
                else if (Command[0] == "sumPairs")
                {
                    Numbers = SumPairs(Numbers, Command);
                }

                Command = Console.ReadLine().Split(' ').ToList();
            }

            Console.WriteLine($"[{string.Join(", ", Numbers)}]");
        }
    }
}
