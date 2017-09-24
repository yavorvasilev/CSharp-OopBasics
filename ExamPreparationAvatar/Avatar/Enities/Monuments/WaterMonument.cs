public class WaterMonument : Monument
{
    private int waterAffinity;

    public WaterMonument(string name, int waterAffinity) : base(name)
    {
        this.waterAffinity = waterAffinity;
        this.Affinity = this.waterAffinity;
    }
    
    public override string ToString()
    {
        return $"###Water Monument: {this.Name}, Water Affinity: {this.waterAffinity}";
    }
}
