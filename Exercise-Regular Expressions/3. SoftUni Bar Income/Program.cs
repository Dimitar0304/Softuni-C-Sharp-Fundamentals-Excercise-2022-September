using System;
using System.Text.RegularExpressions;

namespace _3._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^\%(?<customer>[A-Z][a-z]+)\%[^\|\$\%\.]*?\<(?<product>\w+)\>[^\|\$\%\.]*?\|(?<count>\d+)\|[^\|\$\%\.]*?(?<price>\d+(\.\d+)?)\$$";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            double totalIncome = 0;
            while (input!= "end of shift")
            {
                Match matches = regex.Match(input);
                if (matches.Success)
                {
                    string customerName = matches.Groups["customer"].Value;
                    string product = matches.Groups["product"].Value;
                    int count = int.Parse(matches.Groups["count"].Value);
                    double price = double.Parse(matches.Groups["price"].Value);

                    double totalPrice = count * price;
                    
                    totalIncome += totalPrice;
                    Console.WriteLine($"{customerName}: {product} - {totalPrice:f2}");
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
