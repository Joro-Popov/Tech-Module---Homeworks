using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_of_Last_Digit
{
    class Program
    {
        static string DigitEnglishName(string num)
        {
            string lastDigit = num[num.Length - 1].ToString();
            string EnglishName = string.Empty;

            switch (lastDigit)
            {
                case "0": EnglishName = "zero"; break;
                case "1": EnglishName = "one"; break;
                case "2": EnglishName = "two"; break;
                case "3": EnglishName = "three"; break;
                case "4": EnglishName = "four"; break;
                case "5": EnglishName = "five"; break;
                case "6": EnglishName = "six"; break;
                case "7": EnglishName = "seven"; break;
                case "8": EnglishName = "eight"; break;
                case "9": EnglishName = "nine"; break;
                
            }

            return EnglishName;
        }
        static void Main(string[] args)
        {
            string name = DigitEnglishName(Console.ReadLine());

            Console.WriteLine(name);
        }
    }
}
