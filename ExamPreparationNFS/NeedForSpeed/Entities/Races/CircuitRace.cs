using System.Collections.Generic;
using System.Linq;

public class CircuitRace : Race
{
    private int laps;

    public CircuitRace(int length, string route, int prizePool, int laps) : base(length, route, prizePool)
    {
        this.laps = laps;
    }

    public override int GetPerformancePoints(Car car)
    {
        return (car.Horsepower / car.Acceleration) + (car.Suspension + car.Durability);
    }

    public override List<Car> GetWinners()
    {
        foreach (var car in this.Participants)
        {
            car.Durability -= laps * this.Length * this.Length;
        }
        return this.Participants
            .OrderByDescending(c => (c.Horsepower / c.Acceleration) + (c.Suspension + c.Durability)).Take(4).ToList();
    }

    public override List<int> GetPrizes()
    {
        var result = new List<int>();
        result.Add((this.PrizePool * 40) / 100);
        result.Add((this.PrizePool * 30) / 100);
        result.Add((this.PrizePool * 20) / 100);
        result.Add((this.PrizePool * 10) / 100);

        return result;
    }

    public override string ToString()
    {
        return $"{this.Route} - {this.Length * this.laps}";
    }
}
