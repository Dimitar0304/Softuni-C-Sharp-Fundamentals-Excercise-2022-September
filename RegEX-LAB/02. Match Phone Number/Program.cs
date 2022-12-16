using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+\b359(-| )2\1\d{3}\1\d{4}\b";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);


            Console.WriteLine(string.Join(", ",matches));
        }
    }
}
