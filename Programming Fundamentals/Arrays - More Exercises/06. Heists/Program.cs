using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heists
{
    class Program
    {
        static long GetTotalEarnings(string loot, long jewelsPrice, long goldPrice)
        {
            long jewels = 0;
            long gold = 0;
            long total = 0;

            for (int i = 0; i < loot.Length; i++)
            {
                char currentChar = loot[i];

                if (currentChar == '%')
                {
                    jewels += jewelsPrice;
                }
                else if (currentChar == '$')
                {
                    gold += goldPrice;
                }
            }
            total = jewels + gold;
            return total;
        }
        static void Main(string[] args)
        {
            List<int> Prices = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            long jewelsPRice = Prices[0];
            long goldPrice = Prices[1];

            List<string> LootHeist = Console.ReadLine().Split(' ').ToList();

            long totalEarnings = 0;
            long totalExpenses = 0;

            while (string.Join(" ",LootHeist) != "Jail Time")
            {
                string loot = LootHeist[0];
                int heistExpenses = int.Parse(LootHeist[1]);

                totalEarnings += GetTotalEarnings(loot, jewelsPRice, goldPrice);
                totalExpenses += heistExpenses;

                LootHeist = Console.ReadLine().Split(' ').ToList();
            }

            if (totalEarnings >= totalExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings - totalExpenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {totalExpenses - totalEarnings}.");
            }
        }
    }
}
