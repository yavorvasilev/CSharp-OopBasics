namespace _01Vehicles
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var carInfo = Console.ReadLine().Split();
            var truckInfo = Console.ReadLine().Split();
            var busInfo = Console.ReadLine().Split();

          

            try
            {
                Vehicles car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
                Vehicles truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
                Vehicles bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

                var numberOfCommands = int.Parse(Console.ReadLine());

                for (int i = 0; i < numberOfCommands; i++)
                {
                    var commandInfo = Console.ReadLine().Split();
                    var command = commandInfo[0];
                    var vehicle = commandInfo[1];
                    var param = double.Parse(commandInfo[2]);

                    if (vehicle == "Car" && command == "Drive")
                    {
                        if (car.Driving(param))
                        {
                            Console.WriteLine($"Car travelled {param} km");
                        }
                        else
                        {
                            Console.WriteLine("Car needs refueling");
                        }
                        continue;
                    }
                    if (vehicle == "Car" && command == "Refuel")
                    {
                        car.Refueling(param);
                        continue;
                    }

                    if (vehicle == "Truck" && command == "Drive")
                    {
                        if (truck.Driving(param))
                        {
                            Console.WriteLine($"Truck travelled {param} km");
                        }
                        else
                        {
                            Console.WriteLine("Truck needs refueling");
                        }
                        continue;
                    }
                    if (vehicle == "Truck" && command == "Refuel")
                    {
                        truck.Refueling(param);
                        continue;
                    }
                    if (vehicle == "Bus" && command == "Drive")
                    {
                        if (car.Driving(param))
                        {
                            Console.WriteLine($"Bus travelled {param} km");
                        }
                        else
                        {
                            Console.WriteLine("Bus needs refueling");
                        }
                        continue;
                    }
                    if (vehicle == "Bus" && command == "Refuel")
                    {
                        car.Refueling(param);
                        continue;
                    }
                }
                Console.WriteLine(car);
                Console.WriteLine(truck);
                Console.WriteLine(bus);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
