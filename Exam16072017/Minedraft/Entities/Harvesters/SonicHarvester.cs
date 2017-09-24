using System;

public class SonicHarvester : Harvester
{

    private int sonicFactor;

    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor) : base(id, oreOutput, energyRequirement)
    {
        this.SonicFactor = sonicFactor;
        this.EnergyRequirement = this.EnergyRequirement / this.SonicFactor;
    }

    public int SonicFactor
    {
        get { return this.sonicFactor; }
        private set
        {
            if (value < 1 || value > 10)
            {
                throw new ArgumentException("Harvester is not registered, because of it's SonicFactor");
            }
            this.sonicFactor = value;
        }
    }

    public override double EnergyConsume(string mode)
    {
        if (mode == "Half")
        {
            return this.EnergyRequirement * 0.6;
        }
        else
        {
            return this.EnergyRequirement;
        }

    }

    public override double MineOre(string mode)
    {
        if (mode == "Half")
        {
            return this.OreOutput * 0.5;
        }
        else
        {
            return this.OreOutput;
        }

    }
}
