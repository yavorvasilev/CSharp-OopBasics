﻿using System;

public class AirBender : Bender
{
    private double aerialIntegrity;

    public AirBender(string name, int power, double aerialIntegrity) : base(name, power)
    {
        this.aerialIntegrity = aerialIntegrity;
    }

    public override double GetPower()
    {
        return this.aerialIntegrity * base.Power;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Aerial Integrity: {this.aerialIntegrity:f2}";
    }
}
