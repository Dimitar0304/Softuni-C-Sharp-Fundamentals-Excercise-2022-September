using System;
using System.Collections.Generic;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            //on firt line wwe recive start of for loop firstchar
            //on second line we recive end of for loop secondchar
            //on third line we recive random string that we check for all characters between firstchar and secondchar
            //after that we wwill sum all matches in random string  and print the sum
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string randomString = Console.ReadLine();

            int firstCharCode = (int)firstChar;
            int secondCharCode = (int)secondChar;

            //create char list for put all matches in
            List<char> allMatches = new List<char>();

            // all symbols between the two chars
            for (int i = firstCharCode; i < secondCharCode; i++)
            {
                char currentChar = (char)i;
                for (int y = 0; y < randomString.Length; y++)
                {
                    if (currentChar == randomString[y])
                    {
                        allMatches.Add(randomString[y]);
                        int indexofMatch = randomString.IndexOf(randomString[y]);
                        randomString.Remove(indexofMatch, 1);
                    }
                }
            }
            int result = 0;
            // for loop for calculate sum of asci code
            for (int s = 0; s < allMatches.Count; s++)
            {
                int currentMatchCode = (int)allMatches[s];
                result += currentMatchCode;
            }
            Console.WriteLine(result);
        }
    }
}
