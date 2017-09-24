namespace _14CatLady
{
    public class Cymric : Cat
    {
        public Cymric(string name, string breed, string furLength) : base(name, breed)
        {
            this.Name = name;
            this.Breed = Breed;
            this.FurLength = furLength;
        }
        public string FurLength { get; set; }

        public override string ToString()
        {
            return $"{this.Breed} {this.Name} {this.FurLength}";
        }
    }
}
