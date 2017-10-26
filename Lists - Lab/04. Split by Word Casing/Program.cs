using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Text = Console.ReadLine()
                .Split(new char[] { ',',';',':','.','!','(',')','"','\'','\\','/','[',']',' ' },
                 StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();

            List<string> LowerCase = Text
                .Where(w => w.All(char.IsLower))
                .ToList();

            List<string> UpperCase = Text
                .Where(w => w.All(char.IsUpper))
                .ToList();

            Text = Text
                 .Where(w => !w.All(char.IsLower))
                 .Where(w => !w.All(char.IsUpper))
                 .ToList();

            Console.WriteLine($"Lower-case: {string.Join(", ",LowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ",Text)}");
            Console.WriteLine($"Upper-case: {string.Join(", ",UpperCase)}");
            
        }
    }
}
