using System.Linq;

public abstract class Monument
{
    private string name;

    public Monument(string name)
    {
        this.name = name;
    }

    public override string ToString()
    {
        var typeName = GetType().Name.Replace("Monument", "").Trim();
        return $"###{typeName} Monument: {this.name}";
    }

    public abstract int GetAffinity();
}
