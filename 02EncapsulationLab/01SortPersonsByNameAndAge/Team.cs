using System.Collections.Generic;

class Team
{
    private string name;

    private List<Person> firstTeam;

    private List<Person> reserveTeam;

    public Team(string name)
    {
        this.name = name;
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
    }

    public IReadOnlyCollection<Person> ReserveTeam
    {
        get { return reserveTeam.AsReadOnly(); }
    }


    public IReadOnlyCollection<Person> FirstTeam
    {
        get { return firstTeam.AsReadOnly(); }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public void AddPlayer(Person person)
    {
        if (person.Age < 40)
        {
            this.firstTeam.Add(person);
        }
        else
        {
            this.reserveTeam.Add(person);
        }
    }

}
