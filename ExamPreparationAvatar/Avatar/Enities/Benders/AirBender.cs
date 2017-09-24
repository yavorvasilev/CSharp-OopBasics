public class AirBender : Bender
{
    private double aerialIntegrity;

    public AirBender(string name, int power, double aerialIntegrity) : base(name, power)
    {
        this.aerialIntegrity = aerialIntegrity;
        this.TotalPower = base.Power * aerialIntegrity;
    }

    public override string ToString()
    {
        return $"###Air Bender: {this.Name}, Power: {this.Power}, Aerial Integrity: {this.aerialIntegrity:f2}";
    }
}
