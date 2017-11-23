using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static int GetTotalValue(List<string> Cards)
        {
            int sum = 0;

            for (int i = 0; i < Cards.Count; i++)
            {
                string Tokens = Cards[i];
                int power = 0;

                try
                {
                    string num = Tokens[0].ToString();
                    power = int.Parse(num);

                    if (power == 1)
                    {
                        power = 10;
                        Tokens = Tokens.Remove(1, 1);
                    }
                }
                catch (Exception)
                {
                    char inputChar = char.Parse(Tokens[0].ToString());

                    switch (inputChar)
                    {
                        case 'J': power = 11; break;
                        case 'Q': power = 12; break;
                        case 'K': power = 13; break;
                        case 'A': power = 14; break;
                    }
                }
                char type = char.Parse(Tokens[1].ToString());

                switch (type)
                {
                    case 'S': sum += (power * 4); break;
                    case 'H': sum += (power * 3); break;
                    case 'D': sum += (power * 2); break;
                    case 'C': sum += power; break;
                }

            }
            return sum;
        }
       
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> Players = new Dictionary<string, List<string>>();

            List<string> Input = Console.ReadLine().Split(':').ToList();

            while (string.Join("",Input) != "JOKER")
            {
                string name = Input[0];

                List<string> cards = Input[1].Split(new char[] {' ',','},
                    StringSplitOptions
                    .RemoveEmptyEntries)
                    .Distinct()
                    .ToList();

                if (!Players.ContainsKey(name))
                {
                    Players[name] = cards;
                }
                else
                {
                    Players[name].AddRange(cards);
                    Players[name] = Players[name].Distinct().ToList();
                }

                Input = Console.ReadLine().Split(':').ToList();
            }

            foreach (var player in Players)
            {
                string name = player.Key;
                List<string> Cards = player.Value;

                int totalValue = GetTotalValue(Cards);

                Console.WriteLine($"{name}: {totalValue}");
            }
        }
    }
}
