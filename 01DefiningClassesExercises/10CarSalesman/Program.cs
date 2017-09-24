namespace _10CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var engines = new Dictionary<string, Engine>();
            var cars = new Dictionary<string, Car>();

            var numberOfEngine = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEngine; i++)
            {
                var engineInfo = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var engine = new Engine();
                if (engineInfo.Length == 2)
                {
                     engine = new Engine(engineInfo[0], engineInfo[1]);
                }
                else if (engineInfo.Length == 3)
                {
                    int displacement;
                    if (int.TryParse(engineInfo[2], out displacement))
                    {
                         engine = new Engine(engineInfo[0], engineInfo[1], displacement);
                    }
                    else
                    {
                         engine = new Engine(engineInfo[0], engineInfo[1], engineInfo[2]);
                    }
                }
                else
                {
                     engine = new Engine(engineInfo[0], engineInfo[1], engineInfo[2], engineInfo[3]);
                }
                engines.Add(engineInfo[0], engine);
            }

            var numberOfCar = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCar; i++)
            {
                var carInfo = Console.ReadLine().Trim().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
                var car = new Car();
                if (carInfo.Length == 2)
                {
                    car = new Car(carInfo[0], engines[carInfo[1]]);
                }
                else if (carInfo.Length == 3)
                {
                    int weight;
                    if (int.TryParse(carInfo[2], out weight))
                    {
                        car = new Car(carInfo[0], engines[carInfo[1]], weight);
                    }
                    else
                    {
                        car = new Car(carInfo[0], engines[carInfo[1]], carInfo[2]);
                    }
                }
                else
                {
                    car = new Car(carInfo[0], engines[carInfo[1]], carInfo[2], carInfo[3]);
                }
                cars.Add(carInfo[0], car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.Value);
            }
        }
    }
}
