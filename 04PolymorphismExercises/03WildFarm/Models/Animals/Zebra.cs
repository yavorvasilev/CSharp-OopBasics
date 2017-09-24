using System;

namespace _03WildFarm
{
    public class Zebra : Mammal
    {
        public Zebra(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
        {

        }

        public override string MakeSound()
        {
            return "Zs";
        }
    }
}
