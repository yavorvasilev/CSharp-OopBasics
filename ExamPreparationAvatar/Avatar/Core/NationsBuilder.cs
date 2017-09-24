using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private Dictionary<string, List<Bender>> bendersOfNation;
    private Dictionary<string, List<Monument>> monumentsOfNation;
    private List<string> battles;

    public NationsBuilder()
    {
        bendersOfNation = new Dictionary<string, List<Bender>>()
        {
            { "Air", new List<Bender>()},
            { "Water", new List<Bender>()},
            { "Fire", new List<Bender>()},
            { "Earth", new List<Bender>()}
        };
        monumentsOfNation = new Dictionary<string, List<Monument>>()
        {
            { "Air", new List<Monument>()},
            { "Water", new List<Monument>()},
            { "Fire", new List<Monument>()},
            { "Earth", new List<Monument>()}
        };

        battles = new List<string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        var nationBender = benderArgs[1];
        var nameOfBender = benderArgs[2];
        var powerOfBender = int.Parse(benderArgs[3]);
        var secondaryParameter = double.Parse(benderArgs[4]);

        switch (nationBender)
        {
            case "Air":
                Bender airBender = new AirBender(nameOfBender, powerOfBender, secondaryParameter);
                bendersOfNation[nationBender].Add(airBender);
                break;
            case "Water":
                Bender waterBender = new WaterBender(nameOfBender, powerOfBender, secondaryParameter);
                bendersOfNation[nationBender].Add(waterBender);
                break;
            case "Fire":
                Bender fireBender = new FireBender(nameOfBender, powerOfBender, secondaryParameter);
                bendersOfNation[nationBender].Add(fireBender);
                break;
            case "Earth":
                Bender earthBender = new EarthBender(nameOfBender, powerOfBender, secondaryParameter);
                bendersOfNation[nationBender].Add(earthBender);
                break;
        }
    }
    public void AssignMonument(List<string> monumentArgs)
    {
        var nation = monumentArgs[1];
        var name = monumentArgs[2];
        var affinity = int.Parse(monumentArgs[3]);

        switch (nation)
        {
            case "Air":
                Monument airMonument = new AirMonument(name, affinity);
                monumentsOfNation[nation].Add(airMonument);
                break;
            case "Water":
                Monument waterMonument = new WaterMonument(name, affinity);
                monumentsOfNation[nation].Add(waterMonument);
                break;
            case "Fire":
                Monument fireMonument = new FireMonument(name, affinity);
                monumentsOfNation[nation].Add(fireMonument);
                break;
            case "Earth":
                Monument earthMonument = new EarthMonument(name, affinity);
                monumentsOfNation[nation].Add(earthMonument);
                break;
        }
    }
    public string GetStatus(string nationsType)
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{nationsType} Nation");

        if (bendersOfNation[nationsType].Count != 0)
        {
            sb.AppendLine("Benders:");
            foreach (var bender in bendersOfNation[nationsType])
            {
                sb.AppendLine(bender.ToString());
            }
        }
        else
        {
            sb.AppendLine("Benders: None");
        }

        if (monumentsOfNation[nationsType].Count != 0)
        {
            sb.AppendLine("Monuments:");
            foreach (var monument in monumentsOfNation[nationsType])
            {
                sb.AppendLine(monument.ToString());
            }
        }
        else
        {
            sb.AppendLine("Monuments: None");
        }
        return sb.ToString().Trim();
    }
    public void IssueWar(string nationsType)
    {
        battles.Add(nationsType);

        var totalPoweAirBenders = bendersOfNation["Air"].Sum(b => b.TotalPower);
        var totalPoweWaterBenders = bendersOfNation["Water"].Sum(b => b.TotalPower);
        var totalPoweFireBenders = bendersOfNation["Fire"].Sum(b => b.TotalPower);
        var totalPoweEarthBenders = bendersOfNation["Earth"].Sum(b => b.TotalPower);

        var totalAffinityAirBenders = monumentsOfNation["Air"].Sum(m => m.Affinity);
        var totalAffinityWaterBenders = monumentsOfNation["Water"].Sum(m => m.Affinity);
        var totalAffinityFireBenders = monumentsOfNation["Fire"].Sum(m => m.Affinity);
        var totalAffinityEarthBenders = monumentsOfNation["Earth"].Sum(m => m.Affinity);

        var battlefield = new Dictionary<string, double>();
        double power;

        if (totalPoweAirBenders != 0)
        {
            if (totalAffinityAirBenders != 0)
            {
                power = (totalPoweAirBenders / 100) * totalAffinityAirBenders;
                battlefield["Air"] = power;
                power = 0;
            }
            else
            {
                power = totalPoweAirBenders;
                battlefield["Air"] = power;
                power = 0;
            }
        }

        if (totalPoweWaterBenders != 0)
        {
            if (totalAffinityWaterBenders != 0)
            {
                power = (totalPoweWaterBenders / 100) * totalAffinityWaterBenders;
                battlefield["Water"] = power;
                power = 0;
            }
            else
            {
                power = totalPoweWaterBenders;
                battlefield["Water"] = power;
                power = 0;
            }
        }

        if (totalPoweFireBenders != 0)
        {
            if (totalAffinityFireBenders != 0)
            {
                power = (totalPoweFireBenders / 100) * totalAffinityFireBenders;
                battlefield["Fire"] = power;
                power = 0;
            }

            else
            {
                power = totalPoweFireBenders;
                battlefield["Fire"] = power;
                power = 0;
            }
        }

        if (totalPoweEarthBenders != 0)
        {
            if (totalAffinityEarthBenders != 0)
            {
                power = (totalPoweEarthBenders / 100) * totalAffinityEarthBenders;
                battlefield["Earth"] = power;
                power = 0;
            }

            else
            {
                power = totalPoweEarthBenders;
                battlefield["Earth"] = power;
                power = 0;
            }
        }

        var winnerNation = "";
        var winerPoints = 0d;

        foreach (var battle in battlefield)
        {
            var currentNation = battle.Key;
            var currentPoints = battle.Value;

            if (currentPoints > winerPoints)
            {
                winerPoints = currentPoints;
                winnerNation = currentNation;
            }
        }

        foreach (var nation in bendersOfNation)
        {
            if (nation.Key != winnerNation)
            {
                nation.Value.Clear();
            }
        }

        foreach (var nation in monumentsOfNation)
        {
            if (nation.Key != winnerNation)
            {
                nation.Value.Clear();
            }
        }
    }
    public string GetWarsRecord()
    {
        var sb = new StringBuilder();
        for (int i = 1; i <= battles.Count; i++)
        {
            sb.AppendLine($"War {i} issued by {battles[i - 1]}");
        }
        return sb.ToString().Trim();
    }

}
