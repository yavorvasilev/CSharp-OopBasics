﻿using System;

public class FireMonument : Monument
{
    private int fireAffinity;

    public FireMonument(string name, int fireAffinity) : base(name)
    {
        this.fireAffinity = fireAffinity;
    }

    public override int GetAffinity()
    {
        return this.fireAffinity;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Fire Affinity: {this.fireAffinity}";
    }
}
