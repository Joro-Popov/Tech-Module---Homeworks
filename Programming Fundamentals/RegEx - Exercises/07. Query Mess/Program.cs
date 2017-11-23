using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Query_Mess
{
    class Program
    {
        static string CreateResult(string result, Dictionary<string, List<string>> TempKVPairs)
        {
            foreach (var KV in TempKVPairs)
            {
                string key = KV.Key;
                string values = string.Join(", ", KV.Value);
                result += $"{key}=[{values}]";
            }
            result += "\r\n";
            return result;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;

            while (input != "END")
            {
                Dictionary<string, List<string>> TempKVPairs =
                new Dictionary<string, List<string>>();

                Regex regex = new Regex(@"\+|%20|\s+");
                string replacedInput = regex.Replace(input, " ");

                List<string> KeyValues = replacedInput
                    .Split(new char[] { '?', '&' },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                    .ToList();

                foreach (var KV in KeyValues)
                {
                    string currentKV = KV;

                    Regex KVpattern =
                    new Regex(@"(?<key>.+(?=\=))=(?<value>.*)");
                    Match KVMatch = KVpattern.Match(currentKV);

                    if (KVMatch.Success)
                    {
                        string key =
                        regex.Replace(KVMatch.Groups["key"]
                        .ToString()
                        .Trim(), " ");
                        string value = regex.Replace(KVMatch.Groups["value"]
                            .ToString()
                            .Trim(), " ");

                        if (!TempKVPairs.ContainsKey(key))
                        {
                            TempKVPairs[key] = new List<string>();
                        }
                        TempKVPairs[key].Add(value);
                    }
                }
                result = CreateResult(result, TempKVPairs);

                input = Console.ReadLine();
            }
            Console.WriteLine(result);
        }
        
    }
}
