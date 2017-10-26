using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Resources = new Dictionary<string, int>();

            string[] Input = File.ReadAllLines("Input.txt");
            string resource = string.Empty;
            int quantity = 0;

            for (int i = 0; i <= Input.Length-1; i+=2)
            {
                if (Input[i] == "stop")
                {
                    break;
                }
                else
                {
                    resource = Input[i];
                    quantity = int.Parse(Input[i + 1]);

                    if (!Resources.ContainsKey(resource))
                    {
                        Resources[resource] = 0;
                    }
                    Resources[resource] += quantity;
                }
               
            }

            using (StreamWriter writer = new StreamWriter("Output.txt",true))
            {
                foreach (var item in Resources)
                {
                    string result = ($"{item.Key} -> {item.Value}");

                    writer.WriteLine(result);
                }
            }
        }
    }
}
