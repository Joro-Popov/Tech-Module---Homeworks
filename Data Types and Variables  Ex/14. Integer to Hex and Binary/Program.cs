using System;

namespace _14._Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string hexValue = Convert.ToString(num, 16).ToUpper();
            string binaryValue = Convert.ToString(num, 2);

            Console.WriteLine(hexValue);
            Console.WriteLine(binaryValue);
        }
    }
}
