namespace _12Google
{
    using System.Collections.Generic;

    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
            this.Pokemons = new List<Pokemon>();
        }

        public Person(string name, Company company) : this(name)
        {
            this.Company = company;
        }

        public Person(string name, Car car) : this(name)
        {
            this.Car = car;
        }

        public string Name { get; }
        public Company Company { get; set; }
        public Car Car { get; set; }
        public List<Parent> Parents { get; }
        public List<Child> Children { get; }
        public List<Pokemon> Pokemons { get; }

        public override string ToString()
        {
            return $"{this.Name}\nCompany:\n{this.Company}\nCar:\n{this.Car}\nPokemon:\n{string.Join("\n",this.Pokemons)}\nParents:\n{string.Join("\n", this.Parents)}\nChildren:\n{string.Join("\n", this.Children)}";
        }

    }
}
