namespace _12Google
{
    public class Car
    {
        public Car(string model, int speed)
        {
            this.Model = model;
            this.Speed = speed;
        }

        public string Model { get; }
        public int Speed { get; }

        public override string ToString()
        {
            return $"{this.Model} {this.Speed}";
        }
    }
}
