namespace _03WildFarm
{
    public abstract class Mammal : Animal
    {
        public Mammal(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType,animalName, animalWeight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; set; }


        public override string ToString()
        {
            return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
