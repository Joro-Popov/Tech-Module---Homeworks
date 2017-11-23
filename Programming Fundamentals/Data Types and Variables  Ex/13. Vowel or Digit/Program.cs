using System;

namespace _13._Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine();

            try
            {
                int num = int.Parse(symbol);
                Console.WriteLine("digit");
            }
            catch (Exception)
            {
                if (symbol == "a" || symbol == "e" || symbol == "i" || symbol == "o" || symbol == "u")
                {
                    Console.WriteLine("vowel");
                }
                else
                {
                    Console.WriteLine("other");
                }
            }
        }
    }
}
