using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _03._Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heigh = double.Parse(Console.ReadLine());

            double pixels = Math.Round(((width * heigh) / 1000000),1);

            Console.WriteLine($"{width}x{heigh} => {pixels}MP");
            
        }
    }
}
