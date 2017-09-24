namespace _07SpeedRacing
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var cars = new Dictionary<string, Car>();

            var numberOfCar = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCar; i++)
            {
                var carInfo = Console.ReadLine().Split();
                var car = new Car(carInfo[0], double.Parse(carInfo[1]), double.Parse(carInfo[2]));
                cars.Add(carInfo[0],car);
            }

            var command = Console.ReadLine();

            while (command != "End")
            {
                var tokens = command.Split();
                var car = cars[tokens[1]];
                try
                {
                    car.MoveCar(int.Parse(tokens[2]));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.Value);
            }
        }
    }
}
