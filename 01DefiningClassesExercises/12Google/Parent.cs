namespace _12Google
{
    public class Parent
    {
        public Parent(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public string Name { get; }
        public string Birthday { get; }

        public override string ToString()
        {
            return $"{this.Name} {this.Birthday}";
        }
    }
}
