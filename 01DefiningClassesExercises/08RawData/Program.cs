namespace _08RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var cars = new List<Car>();

            var numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split();
                var carModel = carInfo[0];
                var engine = new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2]));
                var cargo = new Cargo(int.Parse(carInfo[3]), carInfo[4]);
                var tires = new List<Tire>()
                {
                    new Tire(double.Parse(carInfo[5]), int.Parse(carInfo[6])),
                    new Tire(double.Parse(carInfo[7]), int.Parse(carInfo[8])),
                    new Tire(double.Parse(carInfo[9]), int.Parse(carInfo[10])),
                    new Tire(double.Parse(carInfo[11]), int.Parse(carInfo[12])),
                };
                var car = new Car(carModel, engine, cargo, tires);
                cars.Add(car);
            }
            var command = Console.ReadLine();

            if (command == "fragile")
            {
                cars
                    .Where(c => c.Cargo.Type == command && c.Tires.Any(t => t.Pressure < 1))
                    .ToList()
                    .ForEach(c => Console.WriteLine(c.Model));
            }
            else
            {
                cars
                    .Where(c => c.Cargo.Type == command && c.Engine.Power > 250)
                    .ToList()
                    .ForEach(c => Console.WriteLine(c.Model));
            }
        }
    }
}
