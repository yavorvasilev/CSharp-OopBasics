namespace _03WildFarm.Factories
{
    public static class AnimalFactory
    {
        public static Animal GetAnimal(string[] animalTokens)
        {
            var typeOfAnimal = animalTokens[0];
            var name = animalTokens[1];
            var weight = double.Parse(animalTokens[2]);
            var livingRegion = animalTokens[3];

            switch (typeOfAnimal)
            {
                case "Mouse":
                    Animal mouse = new Mouse(typeOfAnimal, name, weight, livingRegion);
                    return mouse;

                case "Zebra":
                    Animal zebra = new Zebra(typeOfAnimal, name, weight, livingRegion);
                    return zebra;

                case "Tiger":
                  Animal tiger = new Tiger(typeOfAnimal, name, weight, livingRegion);
                    return tiger;

                case "Cat":
                    var breed = animalTokens[4];
                    Animal cat = new Cat(typeOfAnimal, name, weight, livingRegion, breed);
                    return cat;
            }
            return null;
        }
    }
}
