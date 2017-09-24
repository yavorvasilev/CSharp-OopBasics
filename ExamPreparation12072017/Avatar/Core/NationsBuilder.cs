using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private Dictionary<string, Nation> nations;
    private List<string> battlesHistory;

    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>()
        {
            { "Air" , new Nation()},
            { "Water" , new Nation()},
            { "Fire" , new Nation()},
            { "Earth" , new Nation()}
        };

        this.battlesHistory = new List<string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        var typeOfBender = benderArgs[1];
        var nameOfBender = benderArgs[2];
        var powerOfBender = int.Parse(benderArgs[3]);
        var secondPower = double.Parse(benderArgs[4]);
        
        switch (typeOfBender)
        {
            case "Air":
                Bender airBender = new AirBender(nameOfBender, powerOfBender, secondPower);
                this.nations[typeOfBender].AddBender(airBender);
                break;
            case "Water":
                Bender waterBender = new WaterBender(nameOfBender, powerOfBender, secondPower);
                this.nations[typeOfBender].AddBender(waterBender);
                break;
            case "Fire":
                Bender fireBender = new FireBender(nameOfBender, powerOfBender, secondPower);
                this.nations[typeOfBender].AddBender(fireBender);
                break;
            case "Earth":
                Bender earthBender = new EarthBender(nameOfBender, powerOfBender, secondPower);
                this.nations[typeOfBender].AddBender(earthBender);
                break;
        }
    }
    public void AssignMonument(List<string> monumentArgs)
    {
        var typeOfMonument = monumentArgs[1];
        var monumentName = monumentArgs[2];
        var affinity = int.Parse(monumentArgs[3]);

        switch (typeOfMonument)
        {
            case "Air":
                Monument airMonument = new AirMonument(monumentName, affinity);
                nations[typeOfMonument].AddMonument(airMonument);
                break;
            case "Water":
                Monument waterMonument = new WaterMonument(monumentName, affinity);
                nations[typeOfMonument].AddMonument(waterMonument);
                break;
            case "Fire":
                Monument fireMonument = new FireMonument(monumentName, affinity);
                nations[typeOfMonument].AddMonument(fireMonument);
                break;
            case "Earth":
                Monument earthMonument = new EarthMonument(monumentName, affinity);
                nations[typeOfMonument].AddMonument(earthMonument);
                break;
        }
    }
    public string GetStatus(string nationsType)
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{nationsType} Nation");
        sb.AppendLine(nations[nationsType].ToString());
        return sb.ToString().Trim();
    }
    public void IssueWar(string nationsType)
    {
        var victoriosPower = this.nations.Max(kvp => kvp.Value.GetPowerOfNation());

        foreach (var nation in nations)
        {
            if (nation.Value.GetPowerOfNation() != victoriosPower)
            {
                nation.Value.DeclareDefeat();
            }
        }

        this.battlesHistory.Add(nationsType);
    }
    public string GetWarsRecord()
    {
        var sb = new StringBuilder();
        for (int i = 1; i <= battlesHistory.Count; i++)
        {
            sb.AppendLine($"War {i} issued by {battlesHistory[i - 1]}");
        }
        return sb.ToString().Trim();
    }

}
