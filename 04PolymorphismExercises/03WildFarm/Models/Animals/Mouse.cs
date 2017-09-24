﻿using System;

namespace _03WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
        {

        }

        public override string MakeSound()
        {
            return "SQUEEEAAAK!";
        }
    }
}
