using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> Resources = new Dictionary<string, long>();

            string command = Console.ReadLine();
            int counter = 0;
            string resource = "";
            long quantity = 0;

            while (command != "stop")
            {
                if (counter % 2 == 0)
                {
                    resource = command;
                    
                }
                else
                {
                    quantity = long.Parse(command);

                    if (!Resources.ContainsKey(resource))
                    {
                        Resources[resource] = quantity;
                    }
                    else
                    {
                        Resources[resource] += quantity;
                    }
                }

                counter++;
                command = Console.ReadLine();
            }

            foreach (var res in Resources)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
