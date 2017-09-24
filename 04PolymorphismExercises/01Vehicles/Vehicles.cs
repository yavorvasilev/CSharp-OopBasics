namespace _01Vehicles
{
    using System;

    public abstract class Vehicles
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public  Vehicles(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }
                this.fuelQuantity = value;
            }
        }
        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }
        public double TankCapacity
        {
            get { return this.tankCapacity; }
            set { this.tankCapacity = value; }
        }

        public abstract bool Driving(double distance);
        public abstract void Refueling(double fuel);
    }
}
