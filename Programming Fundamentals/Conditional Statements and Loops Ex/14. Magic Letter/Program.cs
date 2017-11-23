using System;

namespace _14._Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            string third = Console.ReadLine();

            for (char i = first; i <= second; i++)
            {
                for (char j = first; j <= second; j++)
                {
                    for (char k = first; k <= second; k++)
                    {
                        string combination = $"{i}{j}{k}";

                        if (!combination.Contains(third))
                        {
                            Console.Write($"{combination} ");
                            
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
