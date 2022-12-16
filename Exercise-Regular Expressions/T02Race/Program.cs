using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace T02Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[A-Za-z+]";
            string distancePattern = @"[0-9]";
            string name = string.Empty;

            string[] names = Console.ReadLine().Split(", ");

            //distance for person
  

            //Adding each participant in competition
            Dictionary<string, int> rasers = new Dictionary<string, int>();
            for (int i = 0; i < names.Length; i++)
            {
                rasers[names[i]] = 0;
            }

            //
            Regex regexNames = new Regex(pattern);
            Regex distanceRegex = new Regex(distancePattern);

            

            string input = Console.ReadLine();

            while (input!= "end of race")
            {
                MatchCollection letterMatches = regexNames.Matches(input);
                foreach (Match item in letterMatches)
                {
                    name += item;
                }
                            
                if (rasers.ContainsKey(name))
                {
                    MatchCollection digitMatches = distanceRegex.Matches(input);
                    int currentDistance = 0;
                    foreach (Match digit in digitMatches)
                    {
                        
                        currentDistance += int.Parse(digit.Value);
                    }
                    rasers[name] += currentDistance;
                    currentDistance = 0;
                }
                name = "";
                
                input = Console.ReadLine();
            }
            PrintTopRacers(rasers);

        }
        static string  PrintTopRacers (Dictionary<string,int> rasers)
        {
            
            foreach (var item in rasers.OrderByDescending(r=>r.Value))
            {
                Console.WriteLine($"1st place: {item.Key}");
                rasers.Remove(item.Key);
                break;
            }
            foreach (var item2 in rasers.OrderByDescending(r => r.Value))
            {
                Console.WriteLine($"2nd place: {item2.Key}");
                rasers.Remove(item2.Key);
                break;
            }
            foreach (var item3 in rasers.OrderByDescending(r => r.Value))
            {
                Console.WriteLine($"3rd place: {item3.Key}");
                rasers.Remove(item3.Key);
                break;
            }
            return null;
        }

    }
}
