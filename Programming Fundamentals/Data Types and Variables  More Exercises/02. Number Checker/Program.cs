using System;

namespace _02._Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                ulong num = ulong.Parse(input);
                Console.WriteLine("integer");
            }
            catch (Exception)
            {

                Console.WriteLine("floating-point");
            }
        }
    }
}
