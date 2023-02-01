using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> statistics = new Dictionary<string, int>();

            string command = Console.ReadLine();

            while (command!= "no more time")
            {
                string[] tokens = command.Split("-> ", StringSplitOptions.RemoveEmptyEntries);
                string username = tokens[0];
                string contest = tokens[1];
                int points = int.Parse(tokens[2]);

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, new Dictionary<string, int>());
                }
                if (!contests[contest].ContainsKey(username))
                {
                    contests[contest].Add(username, points);
                }
                else if (contests[contest].ContainsKey(username))
                {
                    if (contests[contest][username]<=points)
                    {
                        contests[contest][username] = points;
                    }
                }
                

                command = Console.ReadLine();
            }

            foreach (var contest in contests)
            {

                int couterfirst = 0;
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                foreach (var participant in contest.Value.OrderByDescending(p=>p.Value).ThenBy(p=>p.Key))
                {
                    if (!statistics.ContainsKey(participant.Key))
                    {
                        statistics.Add(participant.Key, 0);
                    }
                    statistics[participant.Key] += participant.Value;

                    couterfirst++;
                    Console.WriteLine($"{couterfirst}. {participant.Key} <::> {participant.Value}");
                    
                }

            }
            Console.WriteLine("Individual standings:");
            int couter = 0;
            foreach (var user in statistics.OrderByDescending(u=>u.Value).ThenBy(u=>u.Key))
            {
                
                couter++;
                Console.WriteLine($"{couter}. {user.Key} -> {user.Value}");
                
            }
        }
    }
}
