using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    class Sales
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public Sales(string town, string product, decimal price, decimal quantity)
        {
            Town = town;
            Product = product;
            Price = price;
            Quantity = quantity;
        }
    }
    class Program
    {
        static Sales ReadSeles()
        {
            List<string> Tokens = Console.ReadLine().Split(' ').ToList();

            string town = Tokens[0];
            string product = Tokens[1];
            decimal price = decimal.Parse(Tokens[2]);
            decimal quantity = decimal.Parse(Tokens[3]);

            Sales sale = new Sales(town, product, price, quantity);

            return sale;
        }
        static void Main(string[] args)
        {
            SortedDictionary<string, decimal> AllSales = 
            new SortedDictionary<string, decimal>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Sales sale = ReadSeles();
                decimal totalSale = sale.Price * sale.Quantity;

                if (!AllSales.ContainsKey(sale.Town))
                {
                    AllSales[sale.Town] = 0;
                }
                AllSales[sale.Town] += totalSale;
            }

            foreach (var sale in AllSales)
            {
                string town = sale.Key;
                decimal TotalSales = sale.Value;

                Console.WriteLine($"{town} -> {TotalSales:f2}");
            }
        }
    }
}
