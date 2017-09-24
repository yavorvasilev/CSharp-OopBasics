public class FireBender : Bender
{
    private double heatAggression;
    public FireBender(string name, int power, double heatAggression) : base(name, power)
    {
        this.heatAggression = heatAggression;
        this.TotalPower = base.Power * heatAggression;
    }

    public override string ToString()
    {
        return $"###Fire Bender: {this.Name}, Power: {this.Power}, Heat Aggression: {this.heatAggression:f2}";
    }
}
