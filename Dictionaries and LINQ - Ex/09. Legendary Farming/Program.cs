using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> LegendaryItems = new Dictionary<string, int>();
            Dictionary<string, int> KeyMaterials = new Dictionary<string, int>();
            Dictionary<string, int> JunkMaterials = new Dictionary<string, int>();

            LegendaryItems["Shadowmourne"] = 0;
            LegendaryItems["Valanyr"] = 0;
            LegendaryItems["Dragonwrath"] = 0;

            KeyMaterials["shards"] = 0;
            KeyMaterials["fragments"] = 0;
            KeyMaterials["motes"] = 0;

            List<string> Input = Console.ReadLine().Split(' ').ToList();

            bool noWinner = true;

            while (noWinner)
            {
                for (int i = 0; i < Input.Count; i+=2)
                {
                    int quantity = int.Parse(Input[i]);
                    string material = Input[i + 1].ToLower();

                    if (material == "motes" || material == "fragments" || material == "shards")
                    {
                        KeyMaterials[material] += quantity;

                        if (KeyMaterials[material] >= 250)
                        {
                            KeyMaterials[material] -= 250;
                        }

                        if (material == "motes")
                        {
                            LegendaryItems["Dragonwrath"] += quantity;
                        }
                        else if (material == "fragments")
                        {
                            LegendaryItems["Valanyr"] += quantity;
                        }
                        else if (material == "shards")
                        {
                            LegendaryItems["Shadowmourne"] += quantity;
                        }
                    }
                    else
                    {
                        if (!JunkMaterials.ContainsKey(material))
                        {
                            JunkMaterials[material] = 0;
                        }
                        JunkMaterials[material] += quantity;
                    }

                    if (LegendaryItems.Values.Any(w => w >= 250))
                    {
                        noWinner = false;
                        break;
                    }
                }
                if (!noWinner)
                {
                    break;
                }
                Input = Console.ReadLine().Split(' ').ToList();
            }

            LegendaryItems = LegendaryItems
                 .OrderByDescending(w => w.Value)
                 .ToDictionary(p => p.Key, p => p.Value);

            KeyMaterials = KeyMaterials
                .OrderByDescending(w => w.Value)
                .ThenBy(w => w.Key)
                .ToDictionary(p => p.Key, p => p.Value);

            JunkMaterials = JunkMaterials
                .OrderBy(w => w.Key)
                .ToDictionary(p => p.Key, p => p.Value);

            string winner = string.Join("", LegendaryItems.Keys.Take(1).ToList());

            Console.WriteLine($"{winner} obtained!");

            foreach (var material in KeyMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var material in JunkMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}
