using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Phonebook = new Dictionary<string, string>();

            List<string> Command = Console.ReadLine().Split(' ').ToList();

            while (string.Join("",Command) != "END")
            {
                string option = Command[0];

                if (option == "A")
                {
                    string name = Command[1];
                    string number = Command[2];

                    Phonebook[name] = number;
                }
                else if (option == "S")
                {
                    string searchName = Command[1];

                    if (Phonebook.ContainsKey(searchName))
                    {
                        Console.WriteLine($"{searchName} -> {Phonebook[searchName]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {searchName} does not exist.");
                    }
                }

                Command = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
