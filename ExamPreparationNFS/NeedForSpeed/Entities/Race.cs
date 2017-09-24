using System.Collections.Generic;

public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;
    private List<Car> participants;

    public Race(int length, string route, int prizePool)
    {
        this.length = length;
        this.route = route;
        this.prizePool = prizePool;
        this.participants = new List<Car>();
    }

    public string Route { get { return this.route; } }

    public int Length { get { return this.length; } }

    public int PrizePool { get { return this.prizePool; } }

    public List<Car> Participants
    {
        get { return this.participants; }
    }

    public void AddCar(Car car)
    {
        this.participants.Add(car);
    }

    public abstract int GetPerformancePoints(Car car);

    public bool CheckCarsInRace(Car car)
    {
        return this.Participants.Contains(car);
    }

    public abstract List<Car> GetWinners();

    public virtual List<int> GetPrizes()
    {
        var result = new List<int>();
        result.Add((this.prizePool * 50) / 100);
        result.Add((this.prizePool * 30) / 100);
        result.Add((this.prizePool * 20) / 100);

        return result;
    }

    public virtual int GetMoneyFromTimeLimitRace(int timePerformance)
    {
        return 0;
    }

    public virtual string GetMedalFromTimeLimitRace(int timePerformance)
    {
        return "";
    }



    public override string ToString()
    {
        return $"{this.route} - {this.length}";
    }
}
