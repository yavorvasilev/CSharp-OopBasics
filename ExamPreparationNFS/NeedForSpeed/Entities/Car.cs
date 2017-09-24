using System.Text;

public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsepower;
    private int acceleration;
    private int suspension;
    private int durability;

    public Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        this.brand = brand;
        this.model = model;
        this.yearOfProduction = yearOfProduction;
        this.Horsepower = horsepower;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.Durability = durability;
    }

    public string Brand { get { return this.brand; } }
    public string Model { get { return this.model; } }

    public int Horsepower
    {
        get { return this.horsepower; }
        set { this.horsepower = value; }
    }

    public int Acceleration
    {
        get { return this.acceleration; }
        set { this.acceleration = value; }
    }

    public int Durability
    {
        get { return this.durability; }
        set { this.durability = value; }
    }

    public int Suspension
    {
        get { return this.suspension; }
        set { this.suspension = value; }
    }

    public virtual void AddAddons(string addOns)
    {
    }

    public virtual void IncreaseStars(int tuneIndex)
    {
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.brand} {this.model} {this.yearOfProduction}");
        sb.AppendLine($"{this.Horsepower} HP, 100 m/h in {this.acceleration} s");
        sb.AppendLine($"{this.Suspension} Suspension force, {this.durability} Durability");
        return sb.ToString().Trim();
    }


}
