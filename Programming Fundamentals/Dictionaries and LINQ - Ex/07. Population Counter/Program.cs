using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> PopulationData =
            new Dictionary<string, Dictionary<string, long>>();

            List<string> Input = Console.ReadLine().Split('|').ToList();

            while (string.Join("",Input) != "report")
            {
                string city = Input[0];
                string country = Input[1];
                long cityPopulation = long.Parse(Input[2]);

                if (!PopulationData.ContainsKey(country))
                {
                    PopulationData[country] = new Dictionary<string, long>();
                }
                PopulationData[country][city] = cityPopulation;

                Input = Console.ReadLine().Split('|').ToList();
            }

            PopulationData = PopulationData
                .OrderByDescending(w => w.Value.Values.Sum())
                .ToDictionary(p => p.Key, p => p.Value);

            foreach (var cntr in PopulationData)
            {
                string country = cntr.Key;
                Dictionary<string, long> cities = cntr.Value;

                Console.WriteLine($"{country} (total population: {cities.Values.Sum()})");

                foreach (var cty in cities.OrderByDescending(w => w.Value))
                {
                    string city = cty.Key;
                    long population = cty.Value;

                    Console.WriteLine($"=>{city}: {population}");
                }
            }
        }
    }
}
