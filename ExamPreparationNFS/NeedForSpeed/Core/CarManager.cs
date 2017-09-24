using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CarManager
{
    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> openedRaces;
    private Garage garage;


    public CarManager()
    {
        this.cars = new Dictionary<int, Car>();
        this.openedRaces = new Dictionary<int, Race>();
        this.garage = new Garage();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, 
        int horsepower, int acceleration, int suspension, int durability)
    {
        switch (type)
        {
            case "Performance":
                Car performanceCar = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                this.cars[id] = performanceCar;
                break;

            case "Show":
                Car showCar = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                this.cars[id] = showCar;
                break;
        }
    }

    public string Check(int id)
    {
        return cars[id].ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool ,int additionalParam = 0)
    {
        switch (type)
        {
            case "Casual":
                Race casualRace = new CasualRace(length, route, prizePool);
                this.openedRaces[id] = casualRace;
                break;
            case "Drag":
                Race dragRace = new DragRace(length, route, prizePool);
                this.openedRaces[id] = dragRace;
                break;
            case "Drift":
                Race driftRace = new DriftRace(length, route, prizePool);
                this.openedRaces[id] = driftRace;
                break;
            case "TimeLimit":
                Race timeLimitRace = new TimeLimitRace(length, route, prizePool, additionalParam);
                this.openedRaces[id] = timeLimitRace;
                break;

            case "Circuit":
                Race circuitRace = new CircuitRace(length, route, prizePool, additionalParam);
                this.openedRaces[id] = circuitRace;
                break;
        }
    }

    public void Participate(int carId, int raceId)
    {
        var car = cars[carId];
        if (openedRaces.Any(r => r.Key == raceId)) //Check if open this race
        {
            var race = openedRaces[raceId];
            if (!garage.CheckCarsInGarage(car)) //Check the garage
            {
                if (race.GetType().Name == "TimeLimitRace" && race.Participants.Count < 1) // check type of race
                {
                    race.AddCar(car);
                }
                else if (race.GetType().Name != "TimeLimitRace")
                {
                    race.AddCar(car);
                }
            }
        }
    }

    public string Start(int id)
    {
        var race = openedRaces[id];
        if (race.Participants.Count != 0)
        {
            var sb = new StringBuilder();
            sb.AppendLine(race.ToString());

            if (race.GetType().Name == "TimeLimitRace")
            {
                var car = race.GetWinners().FirstOrDefault();
                var timePerformance = race.GetPerformancePoints(car);
                var money = race.GetMoneyFromTimeLimitRace(timePerformance);
                var medal = race.GetMedalFromTimeLimitRace(timePerformance);
                sb.AppendLine($"{car.Brand} {car.Model} - {timePerformance} s.");
                sb.AppendLine($"{medal} Time, ${money}.");
            }
            else
            {
                var winners = race.GetWinners();
                var moneyPrize = race.GetPrizes();
                var count = 1;
                foreach (var winer in winners)
                {
                    sb.AppendLine($"{count}. {winer.Brand} {winer.Model} {race.GetPerformancePoints(winer)}PP - ${moneyPrize[count - 1]}");
                    count++;
                }
            }

            openedRaces.Remove(id);
            return sb.ToString().Trim();
        }
        else
        {
            return "Cannot start the race with zero participants.";
        }
    }

    public void Park(int id)
    {
        var car = cars[id];
        if (!openedRaces.Any(r => r.Value.CheckCarsInRace(car)))
        {
            garage.AddCarInGarage(car);
        }
    }

    public void Unpark(int id)
    {
        var car = cars[id];
        garage.GetOutTheCar(car);
    }
    public void Tune(int tuneIndex, string addOn)
    {
        if (garage.CheckTheGarageIfHaveAnyCar())
        {
            garage.modifyParkedCar(tuneIndex, addOn);
        }
    }

}
