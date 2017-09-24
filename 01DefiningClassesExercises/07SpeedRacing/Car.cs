using System;

namespace _07SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuel;
        private int distance;

        public Car(string model, double fuel, double fuelConsumptionPerKm)
        {
            this.Model = model;
            this.Fuel = fuel;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
            this.Distance = 0;
        }

        public void MoveCar(int distance)
        {
            var neededFuel = this.FuelConsumptionPerKm * distance;

            if (neededFuel <= fuel)
            {
                this.Distance += distance;
                this.Fuel -= neededFuel;
            }
            else
            {
                throw new InvalidOperationException("Insufficient fuel for the drive");
            }
        }


        public double FuelConsumptionPerKm { get; }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public double Fuel
        {
            get { return this.fuel; }
            set { this.fuel = value; }
        }
        public int Distance
        {
            get { return this.distance; }
            set { this.distance = value; }
        }

        public override string ToString()
        {
            var result = $"{this.Model} {this.Fuel:F2} {this.Distance}";
            return result;
        }
    }
}
