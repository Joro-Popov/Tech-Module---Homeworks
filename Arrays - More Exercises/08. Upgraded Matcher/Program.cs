using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Products = Console.ReadLine().Split(' ').ToList();

            List<long> Quantities = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            List<decimal> Prices = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();

            List<string> command = Console.ReadLine().Split(' ').ToList();

            while (string.Join(" ",command) != "done")
            {
                string product = command[0];
                long quantity = long.Parse(command[1]);
                int index = Products.IndexOf(product);

                try
                {
                    if (Quantities[index] >= quantity)
                    {
                        Console.WriteLine($"{product} x {quantity} costs {quantity*Prices[index]:f2}");

                        Quantities[index] -= quantity;
                    }
                    else
                    {
                        Console.WriteLine($"We do not have enough {product}");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine($"We do not have enough {product}");
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
