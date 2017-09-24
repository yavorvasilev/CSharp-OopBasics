using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Nation
{
    private List<Bender> benders;
    private List<Monument> monuments;

    public Nation()
    {
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
    }

    public void AddBender(Bender bender)
    {
        this.benders.Add(bender);
    }

    public void AddMonument(Monument monument)
    {
        this.monuments.Add(monument);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        if (benders.Count != 0)
        {
            sb.AppendLine("Benders:");
            foreach (var bender in benders)
            {
                sb.AppendLine(bender.ToString());
            }
        }
        else
        {
            sb.AppendLine("Benders: None");
        }

        if (monuments.Count != 0)
        {
            sb.AppendLine("Monuments:");
            foreach (var monument in monuments)
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

    public double GetPowerOfNation()
    {
        var totalPower = benders.Sum(b => b.GetPower());
        var sumOfAffinity = monuments.Sum(m => m.GetAffinity());
        var totalPowerIncrese = totalPower / 100 * sumOfAffinity;

        return totalPower + totalPowerIncrese;
    }

    public void DeclareDefeat()
    {
        benders.Clear();
        monuments.Clear();
    }
}
