using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Ingredients = Console.ReadLine().Split(' ').ToList();
            byte searchedLength = byte.Parse(Console.ReadLine());

            List<string> UsedIngredients = new List<string>();
            byte cnt = 0;

            for (int i = 0; i < Ingredients.Count; i++)
            {
                string currentIngredient = Ingredients[i];

                if (currentIngredient.Length == searchedLength)
                {
                    Console.WriteLine($"Adding {currentIngredient}.");
                    UsedIngredients.Add(currentIngredient);
                    cnt++;

                    if (cnt == 10)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"Made pizza with total of {cnt} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ",UsedIngredients)}.");
        }
    }
}
