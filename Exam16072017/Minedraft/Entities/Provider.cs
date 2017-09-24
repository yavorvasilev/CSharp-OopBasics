using System;
using System.Text;

public abstract class Provider
{
    private string id;
    private double energyOutput;

    public Provider(string id, double energyOutput)
    {
        this.id = id;
        this.EnergyOutput = energyOutput;
    }

    public double EnergyOutput
    {
        get { return this.energyOutput; }
        protected set
        {
            if (value < 0 || value >= 10000)
            {
                throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
            }
            this.energyOutput = value;
        }
    }

    public double ProduceEnergy()
    {
        return this.EnergyOutput;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var type = GetType().Name.Replace("Provider", "");

        sb.AppendLine($"{type} Provider - {this.id}");
        sb.AppendLine($"Energy Output: {this.EnergyOutput}");
        return sb.ToString().Trim();
    }
}
