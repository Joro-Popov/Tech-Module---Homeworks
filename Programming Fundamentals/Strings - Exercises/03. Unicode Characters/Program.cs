using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _03.Unicode_Characters
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string Input = Console.ReadLine();

            string[] result = Input
                .Select(w => (int)w)
                .Select(w => $@"\u{w:x4}")
                .ToArray();

            Console.WriteLine(string.Join("",result));
                
        }
    }
}
