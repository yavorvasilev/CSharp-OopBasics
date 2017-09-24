using System;
using System.Collections.Generic;
using System.Linq;

namespace _06FootballTeamGenerator
{
    class Team
    {
        private string name;
        private double rating;
        private Dictionary<string, Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new Dictionary<string, Player>();
            this.rating = 0d;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"A {nameof(this.name)} name should not be empty.");
                }
                this.name = value;
            }
        }

        public void AddPlayer(Player player)
        {
            this.rating += player.OverallSkill;
            this.players.Add(player.Name, player);
        }

        public void RemovePlayer(string playerName)
        {
            if (!this.players.ContainsKey(playerName))
            {
                throw new InvalidOperationException($"Player {playerName} is not in {this.Name} team.");
            }

            var player = players[playerName];
            this.rating -= player.OverallSkill;
            this.players.Remove(player.Name);
        }

        public override string ToString()
        {
            string result = $"{this.Name} - {this.rating}";
            return result;
        }
    }
}
