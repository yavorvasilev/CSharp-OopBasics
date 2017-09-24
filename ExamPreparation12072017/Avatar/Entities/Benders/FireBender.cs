public class FireBender : Bender
{
    private double heatAggression;

    public FireBender(string name, int power, double heatAggression) : base(name, power)
    {
        this.heatAggression = heatAggression;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Heat Aggression: {this.heatAggression:f2}";
    }

    public override double GetPower()
    {
        return this.heatAggression * base.Power;
    }
}
