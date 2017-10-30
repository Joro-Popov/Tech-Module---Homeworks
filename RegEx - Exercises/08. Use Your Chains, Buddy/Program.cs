using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Use_Your_Chains__Buddy
{
    class Program
    {
        static List<string> Replace(MatchCollection ParagraphMatches)
        {
            List<string> ReplacedMatches = new List<string>();

            List<string> Tokens = ParagraphMatches
                .Cast<Match>()
                .Select(w => w.Value)
                .ToList();

            foreach (var token in Tokens)
            {
                string currentToken = token;
                Regex pattern = new Regex(@"[^a-z0-9]+");
                string replaced = pattern.Replace(currentToken, " ");

                ReplacedMatches.Add(replaced);
            }

            return ReplacedMatches;
        }
        static StringBuilder Decrypt(List<string> ExtractedParagraphs)
        {
            StringBuilder Decrypted = new StringBuilder();

            foreach (var token in ExtractedParagraphs)
            {
                StringBuilder currentToken = new StringBuilder(token);

                for (int i = 0; i <= currentToken.ToString().Length-1; i++)
                {
                    char letter = currentToken[i];

                    if (!char.IsDigit(letter) && letter < 110 && letter != ' ')
                    {
                        char newLetter = (char)(letter + 13);
                        currentToken.Remove(i, 1);
                        currentToken.Insert(i, newLetter);
                    }
                    else if (!char.IsDigit(letter) && letter >= 110 && letter != ' ')
                    {
                        char newLetter = (char)(letter - 13);
                        currentToken.Remove(i, 1);
                        currentToken.Insert(i, newLetter);
                    }
                }

                Decrypted.Append(currentToken.ToString());
            }

            return Decrypted;
        }
        static void Main(string[] args)
        {
            string HTMLText = Console.ReadLine();
            Regex ParagrahPatternt = new Regex(@"(?!\<p\>)(?<=\<p\>)(.*?)(?=\<\/p>)");
            
            MatchCollection ParagraphMatches = ParagrahPatternt.Matches(HTMLText);

            List<string> ExtractedParagraphs = 
                Replace(ParagraphMatches);

            StringBuilder result = Decrypt(ExtractedParagraphs);
            Console.WriteLine(result.ToString());
        }
    }
}
