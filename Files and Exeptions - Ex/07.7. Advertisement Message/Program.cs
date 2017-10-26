using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(File.ReadAllText("Input.txt"));

            List<string> Phrases = new List<string>()
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product."
            };

            List<string> Events = new List<string>()
            {
                "Now I fell good.",
                "I have succeeded with this product",
                "Makes miracles.",
                "I am happy of th the results!",
                "I cannot believe but now i fell awesome.",
                "Try it yourself, I am very satisfied.",
                "I fell great!",
            };

            List<string> Authors = new List<string>()
            {
                "Diana","Petya","Stella","Elena","Katya","Iva","Annie","Eva"
            };

            List<string> Cities = new List<string>()
            {
                "Burgas","Sofia","Plovdiv","Varna","Ruse"
            };

            Random rndPhrases = new Random();
            Random rndEvent = new Random();
            Random rndAuthors = new Random();
            Random rndCities = new Random();

            using (StreamWriter writer = new StreamWriter("Output.txt",true))
            {
                for (int i = 0; i < num; i++)
                {
                    int phIndex = rndPhrases.Next(0, Phrases.Count - 1);
                    int evIndex = rndEvent.Next(0, Events.Count - 1);
                    int auIndex = rndAuthors.Next(0, Authors.Count - 1);
                    int cityIndex = rndCities.Next(0, Cities.Count - 1);

                   string result = ($"{Phrases[phIndex]} {Events[evIndex]} {Authors[auIndex]} - {Cities[cityIndex]}");

                    writer.WriteLine(result);
                }
            }
        }
    }
}
