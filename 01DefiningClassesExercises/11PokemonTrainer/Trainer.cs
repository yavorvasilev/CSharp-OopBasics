namespace _11PokemonTrainer
{
    using System.Collections.Generic;

    public class Trainer
    {
        private int numberOfBadges;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            this.Pokemons = new List<Pokemon>();
        }

        public override string ToString()
        {
            return $"{this.Name} {this.NumberOfBadges} {this.Pokemons.Count}";
        }

        public string Name { get; }
        public int NumberOfBadges
        {
            get { return this.numberOfBadges; }
            set { this.numberOfBadges = value; }
        }
        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }

    }
}
