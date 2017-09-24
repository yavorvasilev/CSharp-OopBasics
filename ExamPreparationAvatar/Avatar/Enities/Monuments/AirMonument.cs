﻿public class AirMonument : Monument
{
    private int airAffinity;

    public AirMonument(string name, int airAffinity) : base(name)
    {
        this.airAffinity = airAffinity;
        this.Affinity = this.airAffinity;
    }

   

    public override string ToString()
    {
        return $"###Air Monument: {this.Name}, Air Affinity: {this.airAffinity}";
    }
}
