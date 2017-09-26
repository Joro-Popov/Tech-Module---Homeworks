using System;

namespace _07._Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int cnt = 0;

            while (input != "Bake!")
            {
                cnt++;

                Console.WriteLine($"Adding ingredient {input}.");
                input = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {cnt} ingredients.");
        }
    }
}
