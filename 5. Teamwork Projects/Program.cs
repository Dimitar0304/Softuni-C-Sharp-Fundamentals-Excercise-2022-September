using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Team> teams = new List<Team>();

            InitilizeTeams(teams);
            JoinTeams(teams);

            PrintValidTeams(teams);
            DisbandedTeams(teams);   
        }
        static void InitilizeTeams(List<Team> teams)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] teamInfo = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
                string creator = teamInfo[0];
                string teamName = teamInfo[1];

                if (IsCreatorHasTeam(teams, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else if (IsTeamExsist(teams, teamName))
                {
                    Console.WriteLine($"Team {creator} was already created!");
                }
                else
                {

                    Team team = new Team(teamName, creator);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    teams.Add(team);
                }
            }

        }
        static void JoinTeams(List<Team> teams)
        {
            string input = Console.ReadLine();
            while (input != "end of assignment")
            {
                string[] argInfo = Console.ReadLine().Split("->");
                string user = argInfo[0];
                string teamName = argInfo[1];

                if (!IsTeamExsist(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (IsCurrentUserCanjoinAtTeam(teams, user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    Team teamToJoin = teams.First(t => t.TeamName == teamName);
                    teamToJoin.AddMember(user);
                }


                input = Console.ReadLine();
            }
        }

        static void PrintValidTeams(List<Team> teams)
        {
            List<Team> teamsWithMembers = teams
           .Where(t => t.Members.Count > 0)
           .OrderByDescending(t => t.Members.Count)
           .ThenBy(t => t.TeamName)
           .ToList();
            foreach (var currTeam in teamsWithMembers)
            {
                Console.WriteLine($"{currTeam.TeamName}");
                Console.WriteLine($"- { currTeam.Creator}");
                foreach (var members in currTeam.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {members}");
                }
            }
        }
        static void DisbandedTeams(List<Team> teams)
        {

            List<Team> teamsToDesband = teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.TeamName)
                .ToList();
            Console.WriteLine("Teams to disband:");
            foreach (Team disTeam in teamsToDesband)
            {
                Console.WriteLine($"{disTeam.TeamName}");
            }
        }

        static bool IsCurrentUserCanjoinAtTeam(List<Team>teams,string user)
        {
            return teams.Any(t => t.Members.Contains(user)) || teams.Any(t=>t. Creator == user);
           
        }     
        static bool IsCreatorHasTeam(List<Team> teams, string creator)
        {
            return teams.Any(t => t.Creator == creator);
        }
        static bool IsTeamExsist(List<Team> teams, string teamName)
        {
            return teams.Any(t => t.TeamName == teamName);
        }
    }
    class Team
    {
        private readonly List<string> members;

        public Team(string teamName, string creator)
        {
            this.TeamName = teamName;
            this.Creator = creator;
            this.members = new List<string>();
        }
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members => this.members;

        public void AddMember(string user)
        {
           this.members.Add(user);
        }
    }
}
