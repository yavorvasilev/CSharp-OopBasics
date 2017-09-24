namespace _10CarSalesman
{
    public class Engine
    {
        public Engine()
        {

        }

        public Engine(string model, string power) : this ()
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = "n/a";
            this.Efficiency = "n/a";
        }

        public Engine(string model, string power, int displacement) : this (model, power)
        {
            this.Displacement = displacement.ToString();
        }

        public Engine(string model, string power, string efficiency) : this(model, power)
        {
            this.Efficiency = efficiency;
        }


        public Engine(string model, string power, string displacement, string efficiency) : this(model, power)
        {
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public string Model { get; set; }
        public string Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }
    }
}
