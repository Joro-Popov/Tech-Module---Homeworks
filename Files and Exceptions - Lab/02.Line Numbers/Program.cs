using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Lines = File.ReadAllLines("Input.txt");

            File.WriteAllLines("Output.txt", Lines.Select((line, i) => i + 1 + ". " + line));
        }
    }
}
