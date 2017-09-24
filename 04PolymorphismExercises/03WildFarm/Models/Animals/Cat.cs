using System;

namespace _03WildFarm
{
    public class Cat : Felime
    {
        //private string breed;

        public Cat(string animalType, string animalName, double animalWeight, string livingRegion, string breed) : base(animalType, animalName, animalWeight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get; set; }

        public override string MakeSound()
        {
            return "Meowwww";
        }

        public override string ToString()
        {
            return $"{this.AnimalType}[{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
