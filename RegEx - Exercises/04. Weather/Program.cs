using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Weather
    {
        public double Temperature { get; set; }
        public string WeatherType { get; set; }

        public Weather(double temperature, string type)
        {
            Temperature = temperature;
            WeatherType = type;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Weather> AllCities = 
            new Dictionary<string, Weather>();

            string info = Console.ReadLine();

            while (info != "end")
            {
                Regex WeatherPattern = 
                new Regex(@"(?<city>[A-Z]{2})(?<temp>\d{2}\.\d{1,2})(?<type>[A-z]+)(?=\|)");

                Match match = WeatherPattern.Match(info);

                if (match.Success)
                {
                    string city = match.Groups["city"].ToString();
                    double temperature = double.Parse(match.Groups["temp"].ToString());
                    string weatherType = match.Groups["type"].ToString();

                    if (!AllCities.ContainsKey(city))
                    {
                        AllCities[city] = new Weather(temperature,weatherType);
                    }
                    AllCities[city].Temperature = temperature;
                    AllCities[city].WeatherType = weatherType;
                }

                info = Console.ReadLine();
            }

            foreach (var City in AllCities.OrderBy(w => w.Value.Temperature))
            {
                string city = City.Key;
                double temp = City.Value.Temperature;
                string type = City.Value.WeatherType;

                Console.WriteLine($"{city} => {temp:f2} => {type}");
            }
        }
    }
}
