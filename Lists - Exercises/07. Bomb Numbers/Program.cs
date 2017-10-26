using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> Bomb = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int specialBombNumber = Bomb[0];
            int power = Bomb[1];

            for (int i = 0; i < Input.Count; i++)
            {
                int currentNum = Input[i];

                if (currentNum == specialBombNumber)
                {
                    if (power <= i)
                    {
                        int start = i - power;

                        Input.RemoveRange(start, power);
                    }
                    else
                    {
                        Input.RemoveRange(0, i);
                    }
                    if (power <= (Input.Count-1) -i)
                    {
                        Input.RemoveRange(Input.IndexOf(currentNum)+1, power);
                    }
                    else
                    {
                        int index = Input.IndexOf(currentNum) + 1;
                        Input.RemoveRange(index, Input.Count - index);
                    }
                    Input.RemoveAt(Input.IndexOf(currentNum));
                }
            }

            Console.WriteLine(Input.Sum());
        }
    }
}
