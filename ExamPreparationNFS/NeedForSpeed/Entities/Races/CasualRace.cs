using System;
using System.Collections.Generic;
using System.Linq;

public class CasualRace : Race
{
    public CasualRace(int length, string route, int prizePool) : base(length, route, prizePool)
    {
    }

    public override int GetPerformancePoints(Car car)
    {
        return (car.Horsepower / car.Acceleration) + (car.Suspension + car.Durability);
    }

    public override List<Car> GetWinners()
    {
        return this.Participants
            .OrderByDescending(c => (c.Horsepower / c.Acceleration) + (c.Suspension + c.Durability)).Take(3).ToList();
    }

    public override string ToString()
    {
        return base.ToString().Trim();
    }
}