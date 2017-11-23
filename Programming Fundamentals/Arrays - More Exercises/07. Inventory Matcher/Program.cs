using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Inventory_Matcher
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

            string command = Console.ReadLine();
            string result = string.Empty;

            while (command != "done")
            {
                result += $"{Products[Products.IndexOf(command)]} costs: {Prices[Products.IndexOf(command)]}; Available quantity: {Quantities[Products.IndexOf(command)]}\r\n";

                command = Console.ReadLine();
            }

            Console.WriteLine(result);
        }
    }
}
