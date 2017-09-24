namespace _03WildFarm
{
    using Factories;
    using System;

    public class Startup
    {
        public static void Main()
        {
            var input = "";

            while ((input = Console.ReadLine()) != "End")
            {
                var animalTokens = input.Split(new[] { '\t', ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                var foodTokens = Console.ReadLine().Split(new[] { '\t', ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                Animal animal = AnimalFactory.GetAnimal(animalTokens);
                Food food = FoodFactory.GetFood(foodTokens);

                try
                {
                    Console.WriteLine(animal.MakeSound());
                    animal.Eat(food);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
