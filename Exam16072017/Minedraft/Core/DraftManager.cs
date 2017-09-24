//using Minedraft.Factories;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private Dictionary<string, Harvester> harvesters;
    private Dictionary<string, Provider> providers;
    private double totalStoredEnergy;
    private double totalMinedOre;
    private string mode;

    public DraftManager()
    {
        this.harvesters = new Dictionary<string, Harvester>();
        this.providers = new Dictionary<string, Provider>();
        this.totalStoredEnergy = 0;
        this.totalMinedOre = 0;
        this.mode = "Full";
    }


    public string RegisterHarvester(List<string> arguments)
    {
        var factory = new HarvesterFactory();
        Harvester harvester = factory.GetHarvester(arguments);
        var typeOfHarvester = arguments[0];
        var idOfHarvester = arguments[1];

        if (!harvesters.ContainsKey(idOfHarvester))
        {
            harvesters[idOfHarvester] = harvester;
            return $"Successfully registered {typeOfHarvester} Harvester - {idOfHarvester}";
        }
        return "Harvester is not registered, because of it's Id";

        //var result = "";

        //var typeOfHarvester = arguments[0];
        //var idOfHarvester = arguments[1];
        //var oreOutput = double.Parse(arguments[2]);
        //var energyRequirement = double.Parse(arguments[3]);

        //switch (typeOfHarvester)
        //{
        //    case "Sonic":
        //        var sonicFactor = int.Parse(arguments[4]);
        //        Harvester sonicHarvester = new SonicHarvester(idOfHarvester, oreOutput, energyRequirement, sonicFactor);
        //        this.harvesters[idOfHarvester] = sonicHarvester;
        //        result = $"Successfully registered {typeOfHarvester} Harvester - {idOfHarvester}";
        //        break;

        //    case "Hammer":
        //        Harvester hammeHarvester = new HammerHarvester(idOfHarvester, oreOutput, energyRequirement);
        //        this.harvesters[idOfHarvester] = hammeHarvester;
        //        result = $"Successfully registered {typeOfHarvester} Harvester - {idOfHarvester}";
        //        break;
        //}

        //return result;
    }

    public string RegisterProvider(List<string> arguments)
    {
        var factory = new ProviderFactory();

        Provider provider = factory.GetProvider(arguments);
        var typeOfProvider = arguments[0];
        var idOfProvider = arguments[1];
        providers[idOfProvider] = provider;

        return $"Successfully registered {typeOfProvider} Provider - {idOfProvider}";

        //var result = "";

        //var typeOfProvider = arguments[0];
        //var idOfProvider = arguments[1];
        //var energyOutput = double.Parse(arguments[2]);

        //switch (typeOfProvider)
        //{
        //    case "Solar":
        //        Provider solarProvider = new SolarProvider(idOfProvider, energyOutput);
        //        this.providers[idOfProvider] = solarProvider;
        //        result = $"Successfully registered {typeOfProvider} Provider - {idOfProvider}";
        //        break;

        //    case "Pressure":
        //        Provider pressureProvider = new PressureProvider(idOfProvider, energyOutput);
        //        this.providers[idOfProvider] = pressureProvider;
        //        result = $"Successfully registered {typeOfProvider} Provider - {idOfProvider}";
        //        break;
        //}

        //return result;
    }

    public string Day()
    {

        double producedEnergy = 0;
        double harvesterConsumationOfEnergy = 0;
        double minedOre = 0;
        var sb = new StringBuilder();
        producedEnergy = providers.Sum(p => p.Value.ProduceEnergy());
        sb.AppendLine("A day has passed.");
        sb.AppendLine($"Energy Provided: {producedEnergy}");

        this.totalStoredEnergy += producedEnergy;

        switch (this.mode)
        {
            case "Full":
                harvesterConsumationOfEnergy = harvesters.Sum(h => h.Value.EnergyConsume("Full"));
                if (harvesterConsumationOfEnergy <= totalStoredEnergy)
                {
                    this.totalStoredEnergy -= harvesterConsumationOfEnergy;
                    minedOre = harvesters.Sum(h => h.Value.MineOre("Full"));
                    this.totalMinedOre += minedOre;
                }
                break;

            case "Half":
                harvesterConsumationOfEnergy = harvesters.Sum(h => h.Value.EnergyConsume("Half"));
                if (harvesterConsumationOfEnergy <= totalStoredEnergy)
                {
                    this.totalStoredEnergy -= harvesterConsumationOfEnergy;
                    minedOre = harvesters.Sum(h => h.Value.MineOre("Half"));
                    this.totalMinedOre += minedOre;
                }
                break;

            case "Energy":
                break;
        }
        sb.AppendLine($"Plumbus Ore Mined: {minedOre}");
        return sb.ToString().Trim();
    }

    public string Mode(List<string> arguments)
    {
        var mode = arguments[0];
        this.mode = mode;
        var result = $"Successfully changed working mode to {mode} Mode";

        return result;
    }

    public string Check(List<string> arguments)
    {
        var id = arguments[0];
        if (harvesters.ContainsKey(id))
        {
            var harvester = harvesters[id];
            return $"{harvester.ToString()}";
        }
        if (providers.ContainsKey(id))
        {
            var provider = providers[id];
            return $"{provider.ToString()}";
        }
        return $"No element found with id – {id}";
    }

    public string ShutDown()
    {
        var sb = new StringBuilder();
        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.totalStoredEnergy}");
        sb.AppendLine($"Total Mined Plumbus Ore: {this.totalMinedOre}");

        return sb.ToString().Trim();
    }

}
