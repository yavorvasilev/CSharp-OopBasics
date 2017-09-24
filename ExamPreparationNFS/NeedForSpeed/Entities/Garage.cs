using System.Collections.Generic;

public class Garage
{
    private List<Car> parkedCars;

    public Garage()
    {
        parkedCars = new List<Car>();
    }

    public void AddCarInGarage(Car car)
    {
        this.parkedCars.Add(car);
    }

    public void GetOutTheCar(Car car)
    {
        this.parkedCars.Remove(car);
    }

    public bool CheckCarsInGarage(Car car)
    {
        return parkedCars.Contains(car);
    }

    public bool CheckTheGarageIfHaveAnyCar()
    {
        if (parkedCars.Count != 0)
        {
            return true;
        }
            return false;
       
    }

    public void modifyParkedCar(int tuneIndex, string addOn)
    {
        foreach (var car in parkedCars)
        {
            car.Horsepower += tuneIndex;
            car.Suspension += tuneIndex / 2;

            if (car.GetType().Name == "PerformanceCar")
            {
                car.AddAddons(addOn);
            }
            else
            {
                car.IncreaseStars(tuneIndex);
            }
        }
    }
}


