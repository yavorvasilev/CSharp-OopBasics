namespace _12Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {

            var peoples = new Dictionary<string, Person>();

            var personInfo = Console.ReadLine();

            while (personInfo != "End")
            {
                var tokens = personInfo
                    .Trim()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var property = tokens[1];

                switch (property)
                {
                    case "company": AddPropertyCompany(tokens, peoples);
                        break;

                    case "pokemon": AddPropertyPokemon(tokens, peoples);
                        break;

                    case "parents": AddPropertyParents(tokens, peoples);
                        break;

                    case "children": AddPropertyChildren(tokens, peoples);
                        break;

                    case "car": AddPropertyCar(tokens, peoples);
                        break;
                }


                personInfo = Console.ReadLine();
            }
            var printPerson = Console.ReadLine();

            var res = peoples[printPerson].ToString();
            Console.WriteLine(res.Replace("\n\n", "\n"));
        }

        private static void AddPropertyCar(string[] tokens, Dictionary<string, Person> peoples)
        {
            var nameOfPerson = tokens[0];
            var carModel = tokens[2];
            var carSpeed = int.Parse(tokens[3]);
            var car = new Car(carModel, carSpeed);

            if (!peoples.ContainsKey(nameOfPerson))
            {
                var person = new Person(nameOfPerson, car);
                peoples.Add(nameOfPerson, person);
            }
            else
            {
                peoples[nameOfPerson].Car = car;
            }
        }

        private static void AddPropertyChildren(string[] tokens, Dictionary<string, Person> peoples)
        {
            var nameOfPerson = tokens[0];
            var childName = tokens[2];
            var childBirthday = tokens[3];

            var child = new Child(childName, childBirthday);

            if (!peoples.ContainsKey(nameOfPerson))
            {
                var person = new Person(nameOfPerson);
                person.Children.Add(child);
                peoples.Add(nameOfPerson, person);
            }
            else
            {
                peoples[nameOfPerson].Children.Add(child);
            }
        }

        private static void AddPropertyParents(string[] tokens, Dictionary<string, Person> peoples)
        {
            var nameOfPerson = tokens[0];
            var parentName = tokens[2];
            var parentBirthday = tokens[3];

            var parent = new Parent(parentName, parentBirthday);

            if (!peoples.ContainsKey(nameOfPerson))
            {
                var person = new Person(nameOfPerson);
                person.Parents.Add(parent);
                peoples.Add(nameOfPerson, person);
            }
            else
            {
                peoples[nameOfPerson].Parents.Add(parent);
            }
        }

        private static void AddPropertyPokemon(string[] tokens, Dictionary<string, Person> peoples)
        {
            var nameOfPerson = tokens[0];
            var pokemonName = tokens[2];
            var pokemonType = tokens[3];

            var pokemon = new Pokemon(pokemonName, pokemonType);

            if (!peoples.ContainsKey(nameOfPerson))
            {
                var person = new Person(nameOfPerson);
                person.Pokemons.Add(pokemon);
                peoples.Add(nameOfPerson, person);
            }
            else
            {
                peoples[nameOfPerson].Pokemons.Add(pokemon);
            }
        }

        private static void AddPropertyCompany(string[] tokens, Dictionary<string, Person> peoples)
        {
            var nameOfPerson = tokens[0];
            var comopanyName = tokens[2];
            var department = tokens[3];
            var salary = decimal.Parse(tokens[4]);
            var company = new Company(comopanyName, department, salary);

            if (!peoples.ContainsKey(nameOfPerson))
            {
                var person = new Person(nameOfPerson, company);
                peoples.Add(nameOfPerson, person);
            }
            else
            {
                peoples[nameOfPerson].Company = company;
            }
        }
    }
}
