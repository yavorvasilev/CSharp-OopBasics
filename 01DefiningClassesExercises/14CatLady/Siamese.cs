namespace _14CatLady
{
    public class Siamese : Cat
    {
        public Siamese(string name, string breed, string earSize) : base(name, breed)
        {
            this.Name = Name;
            this.Breed = Breed;
            this.EarSize  = earSize;
        }

        public string EarSize { get; set; }

        public override string ToString()
        {
            return $"{this.Breed} {this.Name} {this.EarSize}";
        }
    }
}
