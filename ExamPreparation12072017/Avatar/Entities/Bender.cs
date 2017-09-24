public abstract class Bender
{
    private string name;
    private int power;

    public Bender(string name, int power)
    {
        this.name = name;
        this.Power = power;
    }

    public int Power
    {
        get { return this.power; }
        set { this.power = value; }
    }

    public abstract double GetPower();

    public override string ToString()
    {
        var typeName = GetType().Name;
        var index = typeName.IndexOf("Bender");
        typeName = typeName.Insert(index, " ");

        return $"###{typeName}: {this.name}, Power: {this.Power}";
    }
}
