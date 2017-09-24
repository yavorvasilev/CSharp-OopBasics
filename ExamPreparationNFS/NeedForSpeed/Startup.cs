using System;

namespace NeedForSpeed
{
    public class Startup
    {
        public static void Main()
        {
            var commandInput = Console.ReadLine();
            var manager = new CarManager();

            while (commandInput != "Cops Are Here")
            {
                var commandTokens = commandInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var commandType = commandTokens[0];

                int carId;
                int raceId;

                switch (commandType)
                {

                    case "register":
                        carId = int.Parse(commandTokens[1]);
                        var typeOfCar = commandTokens[2];
                        var brand = commandTokens[3];
                        var model = commandTokens[4];
                        var yearOfProduction = int.Parse(commandTokens[5]);
                        var horsePower = int.Parse(commandTokens[6]);
                        var acceleration = int.Parse(commandTokens[7]);
                        var suspension = int.Parse(commandTokens[8]);
                        var durability = int.Parse(commandTokens[9]);
                        manager.Register(carId, typeOfCar, brand, model, yearOfProduction, horsePower, acceleration, suspension, durability);
                        break;

                    case "check":
                        Console.WriteLine(manager.Check(int.Parse(commandTokens[1])));
                        break;

                    case "open":

                        raceId = int.Parse(commandTokens[1]);
                        var typeOfRace = commandTokens[2];
                        var length = int.Parse(commandTokens[3]);
                        var route = commandTokens[4];
                        var prizePool = int.Parse(commandTokens[5]);

                        if (commandTokens.Length == 6)
                        {
                            manager.Open(raceId, typeOfRace, length, route, prizePool);
                        }
                        else
                        {
                            var additionalParam = int.Parse(commandTokens[6]);
                            manager.Open(raceId, typeOfRace, length, route, prizePool, additionalParam);
                        }
                        break;

                    case "participate":
                        carId = int.Parse(commandTokens[1]);
                        raceId = int.Parse(commandTokens[2]);
                        manager.Participate(carId, raceId);
                        break;

                    case "start":
                        raceId = int.Parse(commandTokens[1]);
                        Console.WriteLine(manager.Start(raceId));
                        break;

                    case "park":
                        carId = int.Parse(commandTokens[1]);
                        manager.Park(carId);
                        break;

                    case "unpark":
                        carId = int.Parse(commandTokens[1]);
                        manager.Unpark(carId);
                        break;

                    case "tune":
                        var tuneIndex = int.Parse(commandTokens[1]);
                        var tuneAddOn = commandTokens[2];
                        manager.Tune(tuneIndex, tuneAddOn);
                        break;
                }


                commandInput = Console.ReadLine();
            }
        }
    }
}
