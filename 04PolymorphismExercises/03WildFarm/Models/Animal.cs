namespace _03WildFarm
{
    using System;

    public abstract class Animal
    {

        public Animal(string animalType, string animalName, double animalWeight)
        {
            this.AnimalType = animalType;
            this.AnimalName = animalName;
            this.AnimalWeight = animalWeight;
            this.FoodEaten = 0;
        }

        public string AnimalName { get;}
        public string AnimalType { get; }
        public double AnimalWeight { get; }
        public int FoodEaten { get; set; }

        public abstract string MakeSound();

        public void Eat(Food food)
        {
            var animalType = GetType().Name;
            var foodType = food.GetType().Name;
            var foodEaten = false;

            if (foodType == "Meat" && (animalType == "Tiger" || animalType == "Cat"))
            {
                this.FoodEaten += food.Quantity;
                foodEaten = true;
            }
            if (foodType == "Vegetable" && (animalType == "Mouse" || animalType == "Zebra" || animalType == "Cat"))
            {
                this.FoodEaten += food.Quantity;
                foodEaten = true;
            }
            else if(foodEaten == false)
            {
                throw new ArgumentException($"{animalType}s are not eating that type of food!");
            }
           
        }

        
    }
}
