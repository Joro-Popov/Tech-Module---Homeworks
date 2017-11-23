using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volumeML = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            decimal totalKcal = (energy * volumeML) / 100m;
            decimal totalSugars = (sugar * volumeML) / 100m;

            Console.WriteLine($"{volumeML}ml {name}:\r\n{totalKcal}kcal, {totalSugars}g sugars");
        }
    }
}
