namespace _01Vehicles
{
    public class Bus : Vehicles
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }

        public override bool Driving(double distance)
        {
            var neededFuel = distance * (this.FuelConsumption + 1.6);
            if (neededFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= neededFuel;
                return true;
            }
            return false;
        }

        public override void Refueling(double fuel)
        {
            this.FuelQuantity += fuel * 0.95;
        }

        public override string ToString()
        {
            return $"Bus: {this.FuelQuantity:f2}";
        }
    }
}
