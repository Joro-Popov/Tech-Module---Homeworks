using System;

namespace _08._Greater_of_Two_Values
{
    class Program
    {
        static int GetMaxInt(int a,int b)
        {
            if (a >= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static char GetMaxChar(char a, char b)
        {
            if (a >= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static string GetMaxString(string a, string b)
        {
            if (a.CompareTo(b) >= 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMaxInt(a,b));
            }
            else if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());

                Console.WriteLine(GetMaxChar(a,b));
            }
            else if (type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();

                Console.WriteLine(GetMaxString(a,b));
            }
        }
    }
}
