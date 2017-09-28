using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> Games = new Dictionary<string, decimal>();
            Dictionary<string, decimal> boughtGames = new Dictionary<string, decimal>();

            Games["OutFall 4"] = 39.99m;
            Games["CS: OG"] = 15.99m;
            Games["Zplinter Zell"] = 19.99m;
            Games["Honored 2"] = 59.99m;
            Games["RoverWatch"] = 29.99m;
            Games["RoverWatch Origins Edition"] = 39.99m;

            decimal balance = decimal.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "Game Time")
            {
                if (Games.ContainsKey(command))
                {
                    if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                    else if (balance < Games[command])
                    {
                        Console.WriteLine("Too Expensive");
                        
                    }
                    else if (balance >= Games[command])
                    {
                        balance = balance - Games[command];
                        boughtGames[command] = Games[command];
                        Console.WriteLine($"Bought {command}");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                command = Console.ReadLine();
            }

            decimal sum = 0;

            foreach (var game in boughtGames)
            {
                sum += game.Value;
            }
            Console.WriteLine($"Total spent: ${sum:f2}. Remaining: ${balance:f2}");
        }
    }
}
