using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Users = new Dictionary<string, string>();

            string[] Input = File.ReadAllLines("Input.txt");

            for (int i = 0; i <= Input.Length-1; i+=2)
            {
                if (Input[i] == "stop")
                {
                    break;
                }
                string name = Input[i];
                string email = Input[i + 1];

                if (!email.EndsWith(".uk") && !email.EndsWith(".us"))
                {
                    Users[name] = email;
                }
            }

            using (StreamWriter writer = new StreamWriter("Output.txt",true))
            {
                foreach (var user in Users)
                {
                    string result = ($"{user.Key} -> {user.Value}");
                    writer.WriteLine(result);
                }
            }
        }
    }
}
