namespace _06FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static Dictionary<string, Team> teams = new Dictionary<string, Team>();

        public static void Main()
        {
            var line = Console.ReadLine();

            while (line != "END")
            {
                var tokens = line.Split(';');
                var command = tokens[0];

                try
                {
                    switch (command)
                    {
                        case "Team":
                            CreateTeam(tokens[1]);
                            break;

                        case "Add":
                            AddPlayerToTeam(tokens[1],
                                tokens[2],
                                int.Parse(tokens[3]),
                                int.Parse(tokens[4]),
                                int.Parse(tokens[5]),
                                int.Parse(tokens[6]),
                                int.Parse(tokens[7]));
                            break;

                        case "Remove":
                            RemovePlayerFromTeam(tokens[1], tokens[2]);
                            break;

                        case "Rating":
                            PrintRating(tokens[1]);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                

                line = Console.ReadLine();
            }
        }

        private static void PrintRating(string teamName)
        {
            if (!teams.ContainsKey(teamName))
            {
                throw new InvalidOperationException($"Team {teamName} does not exist.");
            }

            var team = teams[teamName];
            Console.WriteLine(team);
        }

        private static void RemovePlayerFromTeam(string teamName, string playerName)
        {
            if (!teams.ContainsKey(teamName))
            {
                throw new InvalidOperationException($"Team {teamName} does not exist.");
            }

            var team = teams[teamName];

            team.RemovePlayer(playerName);
        }

        private static void AddPlayerToTeam(string teamName, 
            string PlayerName, 
            int endurance, 
            int sprint, int dribble, int passing, int shooting)
        {
            if (!teams.ContainsKey(teamName))
            {
                throw new InvalidOperationException($"Team {teamName} does not exist.");
            }

            var player = new Player(
                PlayerName,
            new Stat("Endurance", endurance),
            new Stat("Sprint", sprint),
            new Stat("Dribble", dribble),
            new Stat("Passing", passing),
            new Stat("shooting", shooting)
               );

            var team = teams[teamName];
            team.AddPlayer(player);
        }

        private static void CreateTeam(string name)
        {
            var team = new Team(name);
            teams.Add(name, team);
        }
    }
}
