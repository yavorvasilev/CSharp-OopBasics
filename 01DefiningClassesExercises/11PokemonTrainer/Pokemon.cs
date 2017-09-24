namespace _11PokemonTrainer
{
    public class Pokemon
    {
        private int health;

        public Pokemon(string name, string element, int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }

        public int Health
        {
            get { return this.health;  }
            set { this.health = value; }
        }
        public string Name { get; }
        public string Element { get; }
    }
}
