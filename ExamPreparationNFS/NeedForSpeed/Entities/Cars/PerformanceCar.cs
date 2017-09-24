using System.Collections.Generic;
using System.Text;

public class PerformanceCar : Car
{
    private List<string> addOns;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability) 
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.Horsepower = this.Horsepower + (base.Horsepower * 50) / 100;
        this.Suspension = this.Suspension - (base.Suspension * 25) / 100;
        this.addOns = new List<string>();
    }

    public override void AddAddons(string addOns)
    {
        this.addOns.Add(addOns);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        if (addOns.Count != 0)
        {
            sb.AppendLine($"Add-ons: {string.Join(", ", addOns)}");
        }
        else
        {
            sb.AppendLine("Add-ons: None");
        }
        return sb.ToString().Trim();
    }
}
