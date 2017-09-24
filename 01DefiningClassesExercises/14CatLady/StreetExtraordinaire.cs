namespace _14CatLady
{
    public  class StreetExtraordinaire : Cat
    {
        public StreetExtraordinaire(string name, string breed, string decibelsOfMeows) : base(name, breed)
        {
            this.Name = name;
            this.Breed = breed;
            this.DecibelsOfMeows = decibelsOfMeows;
        }


        public string DecibelsOfMeows { get; set; }

        public override string ToString()
        {
            return $"{this.Breed} {this.Name} {this.DecibelsOfMeows}";
        }
    }
}
