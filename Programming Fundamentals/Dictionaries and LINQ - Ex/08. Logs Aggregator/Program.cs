using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string,int>> UserData =
            new Dictionary<string, Dictionary<string,int>>();

            short count = short.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                List<string> Input = Console.ReadLine().Split(' ').ToList();

                string IP = Input[0];
                string user = Input[1];
                int duration = int.Parse(Input[2]);

                if (!UserData.ContainsKey(user))
                {
                    UserData[user] = new Dictionary<string, int>();
                }
                if (!UserData[user].ContainsKey(IP))
                {
                    UserData[user][IP] = duration;
                }
                else
                {
                    UserData[user][IP] += duration;
                }
            }

            foreach (var usr in UserData.OrderBy(w => w.Key))
            {
                string user = usr.Key;;
                Dictionary<string, int> IPs = usr.Value;

                List<string> IPlist = IPs.Keys.Distinct().OrderBy(w => w).ToList();
                int durations = IPs.Values.Sum();

                Console.WriteLine($"{user}: {durations} [{string.Join(", ",IPlist)}]");
            }
        }
    }
}
