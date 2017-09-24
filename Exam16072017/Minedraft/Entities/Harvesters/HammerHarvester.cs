public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement) : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput += this.OreOutput * 2;
        this.EnergyRequirement += this.EnergyRequirement;
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
