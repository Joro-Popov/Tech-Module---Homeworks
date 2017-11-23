using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Info = new Dictionary<string, string>();

            string name = Console.ReadLine();

            while (name != "stop")
            {
                string email = Console.ReadLine();

                Info[name] = email;

                name = Console.ReadLine();
            }

            Info = Info
                .Where(w => !w.Value.EndsWith(".uk") && !w.Value.EndsWith(".us"))
                .ToDictionary(p => p.Key, p => p.Value);

            foreach (var item in Info)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
