using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Users = new Dictionary<string, string>();
            Regex PlatePattern = new Regex(@"^[A-Z]{2}[0-9]{4}[A-Z]{2}$");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                List<string> Command = Console.ReadLine().Split(' ').ToList();
                string user = Command[1];

                if (Command[0] == "register")
                {
                    string plateNumber = Command[2];

                    if (PlatePattern.IsMatch(plateNumber))
                    {
                        if (!Users.Keys.Contains(user))
                        {
                            if (!Users.Values.Contains(plateNumber))
                            {
                                Users[user] = plateNumber;
                                Console.WriteLine($"{user} registered {plateNumber} successfully");
                            }
                            else
                            {
                                Console.WriteLine($"ERROR: license plate {plateNumber} is busy");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {Users[user]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: invalid license plate {plateNumber}");
                    }
                }
                else
                {
                    if (Users.ContainsKey(user))
                    {
                        Console.WriteLine($"user {user} unregistered successfully");
                        Users.Remove(user);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                }
            }

            foreach (var usr in Users)
            {
                string name = usr.Key;
                string plate = usr.Value;

                Console.WriteLine($"{name} => {plate}");
            }
        }
    }
}
