using System.Collections.Generic;

public class HarvesterFactory
{
    public Harvester GetHarvester(List<string> arguments)
    {
        var typeOfHarvester = arguments[0];
        var idOfHarvester = arguments[1];
        var oreOutput = double.Parse(arguments[2]);
        var energyRequirement = double.Parse(arguments[3]);

        switch (typeOfHarvester)
        {
            case "Sonic":
                var sonicFactor = int.Parse(arguments[4]);
                Harvester sonicHarvester = new SonicHarvester(idOfHarvester, oreOutput, energyRequirement, sonicFactor);
                return sonicHarvester;

            case "Hammer":
                Harvester hammeHarvester = new HammerHarvester(idOfHarvester, oreOutput, energyRequirement);
                return hammeHarvester;
        }
        return null;
    }
}
