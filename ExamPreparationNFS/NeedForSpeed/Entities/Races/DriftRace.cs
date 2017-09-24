using System.Collections.Generic;
using System.Linq;

public class DriftRace : Race
{
    public DriftRace(int length, string route, int prizePool) : base(length, route, prizePool)
    {

    }

    public override int GetPerformancePoints(Car car)
    {
        return car.Suspension + car.Durability;
    }

    public override List<Car> GetWinners()
    {
        return this.Participants
            .OrderByDescending(c => (c.Suspension + c.Durability)).Take(3).ToList();
    }

    public override string ToString()
    {
        return base.ToString().Trim();
    }
}
