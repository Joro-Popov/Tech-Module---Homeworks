using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> Users = 
            new SortedDictionary<string, Dictionary<string, int>>();

            List<string> Input = Console.ReadLine().Split(' ').ToList();

            while (string.Join("", Input) != "end")
            {
                List<string> TokenIP = Input[0]
                    .Split(new string[] { "IP=" },
                     StringSplitOptions
                    .RemoveEmptyEntries)
                    .ToList();

                List<string> TokenUser = Input[2]
                    .Split(new string[] { "user=" },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                    .ToList();

                string IP = string.Join("", TokenIP);
                string user = string.Join("", TokenUser);

                if (!Users.ContainsKey(user))
                {
                    Users[user] = new Dictionary<string, int>();
                    
                }
                if (!Users[user].ContainsKey(IP))
                {
                    Users[user][IP] = 0;
                }
                Users[user][IP]++;

                Input = Console.ReadLine().Split(' ').ToList();
            }

            foreach (var usr in Users)
            {
                string username = usr.Key;

                Dictionary<string, int> IPs = usr.Value;

                Console.WriteLine($"{username}: ");

                List<string> ConcatIPs = new List<string>();

                foreach (var ip in IPs)
                {
                    string IP = ip.Key;
                    int count = ip.Value;

                    string token = $"{IP} => {count}";

                    ConcatIPs.Add(token);
                }
                Console.WriteLine($"{string.Join(", ", ConcatIPs)}.");
            }
        }
    }
}
