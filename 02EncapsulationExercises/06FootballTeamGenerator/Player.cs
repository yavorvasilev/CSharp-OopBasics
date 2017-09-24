using System;

namespace _06FootballTeamGenerator
{
    class Player
    {
        private string name;
        private double overallSkill;

        public Player(string name, Stat endurance, Stat sprint, Stat dribble, Stat passing, Stat shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;

            this.CalculateAverageStats();
        }

        private void CalculateAverageStats()
        {
            double sumOfStats = (this.Endurance.Level + this.Sprint.Level + this.Dribble.Level + this.Passing.Level + this.Shooting.Level);
            this.OverallSkill = Math.Round((sumOfStats / 5), 0);
        }


        public Stat Endurance { get; }
        public Stat Sprint { get; }
        public Stat Dribble { get; }
        public Stat Passing { get; }
        public Stat Shooting { get; }
        public double OverallSkill
        {
            get { return this.overallSkill; }
            private set { this.overallSkill = value; }
        }

        public string Name
        {
            get { return this.name;  }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"A {nameof(this.name)} name should not be empty.");
                }
                this.name = value;
            }
        }
    }
}
