namespace _06FootballTeamGenerator
{
    using System;

    class Stat
    {
        private const int LevelMinValue = 0;
        private const int LevelMaxValue = 100;

        private string name;
        private int level;

        public Stat(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Level
        {
            get { return this.level; }
            set
            {
                if (value < LevelMinValue || value > LevelMaxValue)
                {
                    throw new ArgumentException($"{this.Name} should be between {LevelMinValue} and {LevelMaxValue}.");
                }
                this.level = value;
            }
        }
    }
}
