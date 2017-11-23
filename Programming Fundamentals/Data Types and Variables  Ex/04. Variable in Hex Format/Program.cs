using System;

namespace _04._Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexadecimalNumber = Console.ReadLine();
            decimal number = Convert.ToInt32(hexadecimalNumber, 16);

            Console.WriteLine(number);
        }
    }
}
