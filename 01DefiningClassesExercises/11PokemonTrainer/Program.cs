namespace _11PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var trainers = new Dictionary<string, Trainer>();

            var trainerInfo = Console.ReadLine();

            while (trainerInfo != "Tournament")
            {
                var tokens = trainerInfo.Split();
                var trainerName = tokens[0];
                var nameOfPokemon = tokens[1];
                var element = tokens[2];
                var health = int.Parse(tokens[3]);
                var pokemon = new Pokemon(nameOfPokemon, element, health);
                if (!trainers.ContainsKey(trainerName))
                {
                    var trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainerName, trainer);
                }
                else
                {
                    trainers[trainerName].Pokemons.Add(pokemon);
                }

                trainerInfo = Console.ReadLine();
            }

            var elementCommand = Console.ReadLine();

            while (elementCommand != "End")
            {
                foreach (var train in trainers)
                {
                    if (train.Value.Pokemons.Any(p => p.Element == elementCommand))
                    {
                        train.Value.NumberOfBadges += 1;
                    }
                    else
                    {
                        train.Value.Pokemons.ForEach(p => p.Health -= 10);
                        if (train.Value.Pokemons.Any(p => p.Health <= 0))
                        {
                            train.Value.Pokemons.RemoveAll(p => p.Health <= 0);
                        }
                    }
                }
                elementCommand = Console.ReadLine();
            }
            Console.WriteLine();
            foreach (var trainer in trainers.OrderByDescending(p => p.Value.NumberOfBadges))
            {
                Console.WriteLine(trainer.Value);
            }
        }
    }
}
