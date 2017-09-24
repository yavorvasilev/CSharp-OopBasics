using System;
using System.Collections.Generic;

public class Garage
{
    public Garage()
    {
        this.ParkedCars = new List<int>();
    }

    public List<int> ParkedCars { get; set; }

    public void AddCar(int id)
    {
        this.ParkedCars.Add(id);
    }

    public  void RemoveCar(int id)
    {
        this.ParkedCars.Remove(id);
    }
}
