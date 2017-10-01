using System;

namespace _07._Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Before:\r\na = {b}\r\nb = {a}");
            Console.WriteLine($"After:\r\na = {a}\r\nb = {b}");
        }
    }
}
