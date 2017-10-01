using System;

namespace _04._Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            float value = float.Parse(Console.ReadLine());
            double resultValue = 0;

            if (imperialUnit == "miles")
            {
                resultValue = value * 1.6;
                Console.WriteLine($"{value} miles = {resultValue:f2} kilometers");
            }
            else if (imperialUnit == "inches")
            {
                resultValue = value * 2.54;
                Console.WriteLine($"{value} inches = {resultValue:f2} centimeters");
            }
            else if (imperialUnit == "feet")
            {
                resultValue = value * 30;
                Console.WriteLine($"{value} feet = {resultValue:f2} centimeters");
            }
            else if (imperialUnit == "yards")
            {
                resultValue = value * 0.91;
                Console.WriteLine($"{value} yards = {resultValue:f2} meters");
            }
            else if (imperialUnit == "gallons")
            {
                resultValue = value * 3.8;
                Console.WriteLine($"{value} gallons = {resultValue:f2} liters");
            }
            
        }
    }
}
