using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^>>(?<furniture>[A-Z,a-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+){0,1}$";
            string input = Console.ReadLine();
            List<string> furnitures = new List<string>();
            double totalMoneySpend = 0;

            while (input!="Purchase")
            {
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    furnitures.Add(match.Groups["furniture"].Value);
                    totalMoneySpend += double.Parse(match.Groups["price"].Value) * double.Parse(match.Groups["quantity"].Value);
                }
                input = Console.ReadLine();
            }
            
            
            Console.WriteLine("Bought furniture:");
            foreach (var furn in furnitures)
            {
                Console.WriteLine(furn);
            }
            Console.WriteLine($"Total money spend: {totalMoneySpend:F2}");
        }
    }
}
