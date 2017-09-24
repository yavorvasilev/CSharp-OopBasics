using System.Collections.Generic;

public class ProviderFactory
{
    public Provider GetProvider(List<string> arguments)
    {
        var typeOfProvider = arguments[0];
        var idOfProvider = arguments[1];
        var energyOutput = double.Parse(arguments[2]);

        switch (typeOfProvider)
        {
            case "Solar":
                Provider solarProvider = new SolarProvider(idOfProvider, energyOutput);
                //this.providers[idOfProvider] = solarProvider;
                //result = $"Successfully registered {typeOfProvider} Provider - {idOfProvider}";
                return solarProvider;

            case "Pressure":
                Provider pressureProvider = new PressureProvider(idOfProvider, energyOutput);
                return pressureProvider;
                //this.providers[idOfProvider] = pressureProvider;
                //result = $"Successfully registered {typeOfProvider} Provider - {idOfProvider}";
                //break;
        }

        return null;
    }
}