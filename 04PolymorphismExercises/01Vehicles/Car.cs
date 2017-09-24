namespace _01Vehicles
{
    using System;

    public class Car:Vehicles
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity) 
        {

        }

        public override bool Driving(double distance)
        {
            var neededFuel = distance * (this.FuelConsumption + 0.9);
            if (neededFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= neededFuel;
                return true;
            }
            return false;
        }

        public override void Refueling(double fuel)
        {
            if (fuel + this.FuelQuantity <= this.TankCapacity)
            {
                this.FuelQuantity += fuel;
            }
        }
        public override string ToString()
        {
            return $"Car: {this.FuelQuantity:f2}";
        }
    }
}
