using System;
using System.Text;

public abstract class Harvester
{
    private string id;
    private double oreOutput;
    private double energyRequirement;


    public Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public double OreOutput
    {
        get { return this.oreOutput; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Harvester is not registered, because of it's OreOutput");
            }
            this.oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get { return this.energyRequirement; }
        protected set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement");
            }
            this.energyRequirement = value;
        }
    }

    public abstract double EnergyConsume(string mode);
    //{
    //    return this.EnergyRequirement;
    //}

    public abstract double MineOre(string mode);
    //{
    //    return this.OreOutput;
    //}

    public override string ToString()
    {
        var sb = new StringBuilder();
        var type = GetType().Name.Replace("Harvester", "");

        sb.AppendLine($"{type} Harvester - {this.id}");
        sb.AppendLine($"Ore Output: {this.OreOutput}");
        sb.AppendLine($"Energy Requirement: {this.EnergyRequirement}");
        return sb.ToString().Trim();
    }

}
