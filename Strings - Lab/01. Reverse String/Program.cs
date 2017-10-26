using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input = Console.ReadLine();
            char[] reversed = Input.Reverse().ToArray();

            Console.WriteLine(string.Join("",reversed));
        }
    }
}
