using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Client
    {
        public string Name { get; set; }
        public Dictionary<string,long> Products { get; set; }
        public decimal Bill { get; set; }

        public Client(string name, string product, long quantity)
        {
            Name = name;
            Products = new Dictionary<string, long>();
            Bill = 0;
        }
    }
    class Program
    {
        static decimal GetClientBill(Dictionary<string,long> ClientProds,Dictionary<string,decimal> Entities)
        {
            decimal bill = 0;

            foreach (var item in ClientProds)
            {
                bill += item.Value * Entities[item.Key];
            }

            return bill;
        }
        static decimal GetTotalBill(List<Client> AllClients,Dictionary<string,decimal> Entities)
        {
            decimal total = 0;

            foreach (var client in AllClients)
            {
                Dictionary<string, long> prods = client.Products;

                foreach (var prod in prods)
                {
                    total += prod.Value * Entities[prod.Key];
                }
            }

            return total;
        }
        static void Main(string[] args)
        {
            Dictionary<string, decimal> Entities = 
            new Dictionary<string, decimal>();

            List<Client> AllClients = new List<Client>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                List<string> InputEntities = Console.ReadLine().Split('-').ToList();

                string product = InputEntities[0];
                decimal price = decimal.Parse(InputEntities[1]);

                Entities[product] = price;
            }

            List<string> Clients = Console.ReadLine().Split(new char[] { '-', ',' }
            , StringSplitOptions
            .RemoveEmptyEntries)
            .ToList();
            
            while (string.Join("",Clients) != "end of clients")
            {
                string name = Clients[0];
                string product = Clients[1];
                long quantity = long.Parse(Clients[2]);

                if (Entities.ContainsKey(product))
                {
                    Client client = new Client(name, product, quantity);

                    if (!client.Products.ContainsKey(product))
                    {
                        client.Products[product] = 0;
                    }
                    client.Products[product] += quantity;

                    client.Bill = GetClientBill(client.Products,Entities);
                    AllClients.Add(client);
                }

                Clients = Console.ReadLine().Split(new char[] { '-', ',' }
                            , StringSplitOptions
                            .RemoveEmptyEntries)
                            .ToList();
            }

            AllClients = AllClients
                .OrderBy(w => w.Name)
                .ToList();

            foreach (var clien in AllClients)
            {
                string name = clien.Name;
                Dictionary<string, long> products = clien.Products;

                Console.WriteLine(name);

                foreach (var prod in products)
                {
                    Console.WriteLine($"-- {prod.Key} - {prod.Value}");
                }
                Console.WriteLine($"Bill: {clien.Bill:f2}");
            }

            decimal TotalBill = GetTotalBill(AllClients, Entities);
            Console.WriteLine($"Total bill: {TotalBill:f2}");
        }
    }
}
