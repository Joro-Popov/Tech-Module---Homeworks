using System;
using System.Collections.Generic;
using System.Numerics;

namespace _18._Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Types = new List<string>();

            BigInteger num = BigInteger.Parse(Console.ReadLine());

            if (num >= sbyte.MinValue && num <= sbyte.MaxValue)
            {
                Types.Add("sbyte");
            }
            if (num >=0 && num <= byte.MaxValue)
            {
                Types.Add("byte");
            }
            if (num >= short.MinValue && num <= short.MaxValue)
            {
                Types.Add("short");
            }
            if (num >= ushort.MinValue && num <= ushort.MaxValue)
            {
                Types.Add("ushort");
            }
            if (num >= int.MinValue && num <= int.MaxValue)
            {
                Types.Add("int");
            }
            if (num >= uint.MinValue && num <= uint.MaxValue)
            {
                Types.Add("uint");
            }
            if (num >= long.MinValue && num <= long.MaxValue)
            {
                Types.Add("long");
            }

            if (Types.Count == 0)
            {
                Console.WriteLine($"{num} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{num} can fit in:");

                foreach (var type in Types)
                {
                    Console.WriteLine($"* {type}");
                }
            }
        }
    }
}
