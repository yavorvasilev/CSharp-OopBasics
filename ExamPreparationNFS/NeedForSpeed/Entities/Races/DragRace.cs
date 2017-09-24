using System;
using System.Collections.Generic;
using System.Linq;

public class DragRace : Race
{
    public DragRace(int length, string route, int prizePool) : base(length, route, prizePool)
    {
    }

    public override int GetPerformancePoints(Car car)
    {
        return car.Horsepower / car.Acceleration;
    }

    public override List<Car> GetWinners()
    {
        return this.Participants
            .OrderByDescending(c => (c.Horsepower / c.Acceleration)).Take(3).ToList();
    }

    public override string ToString()
    {
        return base.ToString().Trim();
    }
}
