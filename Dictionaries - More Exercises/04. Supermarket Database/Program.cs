using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Supermarket_Database
{
    class Product
    {
        public decimal price { get; set; }
        public int quantity { get; set; }

        public Product(decimal Price, int Quantity)
        {
            price = Price;
            quantity = Quantity;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> AllProducts = 
            new Dictionary<string, Product>();

            List<string> Product = Console.ReadLine().Split(' ').ToList();

            while (string.Join("",Product) != "stocked")
            {
                string product = Product[0];
                decimal price = decimal.Parse(Product[1]);
                int quantity = int.Parse(Product[2]);

                Product current = new Product(price, quantity);

                if (!AllProducts.ContainsKey(product))
                {
                    AllProducts[product] = current;
                }
                else
                {
                    AllProducts[product].price = price;
                    AllProducts[product].quantity += quantity;
                }

                Product = Console.ReadLine().Split(' ').ToList();
            }

            decimal grandTotal = 0;

            foreach (var prod in AllProducts)
            {
                string name = prod.Key;
                Product properties = prod.Value;
                decimal total = properties.price * properties.quantity;

                Console.WriteLine($"{name}: ${properties.price} * {properties.quantity} = ${total}");

                grandTotal += total;
            }
            Console.WriteLine($"------------------------------");
            Console.WriteLine($"Grand Total: ${grandTotal}");
        }
    }
}
