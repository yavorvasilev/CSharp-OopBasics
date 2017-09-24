namespace _03WildFarm.Factories
{
    public static class FoodFactory
    {
        public static Food GetFood(string[] foodTokens)
        {
            var foodType = foodTokens[0];
            var foodQuantity = int.Parse(foodTokens[1]);

            switch (foodType)
            {
                case "Vegetable":
                    Food vegetable = new Vegetable(foodQuantity);
                    return vegetable;

                case "Meat":
                    Food meat = new Meat(foodQuantity);
                    return meat;
            }
            return null;
        }
    }
}
