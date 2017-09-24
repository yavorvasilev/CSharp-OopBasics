using System;
using System.Collections.Generic;

public class TimeLimitRace : Race
{
    private int goldTime;

    public TimeLimitRace(int length, string route, int prizePool, int goldTime) : base(length, route, prizePool)
    {
        this.goldTime = goldTime;
    }

    public override int GetPerformancePoints(Car car)
    {
        return this.Length * ((car.Horsepower / 100) * car.Acceleration);
    }

    public override string GetMedalFromTimeLimitRace(int timePerformance)
    {
        if (timePerformance <= this.goldTime)
        {
            return "Gold";
        }
        if (timePerformance <= this.goldTime + 15)
        {
            return "Silver";
        }
        else
        {
            return "Bronze";
        }
    }

    public override int GetMoneyFromTimeLimitRace(int timePerformance)
    {
        if (timePerformance <= this.goldTime)
        {
            return this.PrizePool;
        }
        if (timePerformance <= this.goldTime + 15)
        {
            return (this.PrizePool * 50) / 100;
        }
        else
        {
            return (this.PrizePool * 30) / 100;
        }
    }

    public override List<Car> GetWinners()
    {
        return this.Participants;
    }
}

