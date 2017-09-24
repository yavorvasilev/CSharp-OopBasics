using System;
using System.Linq;

namespace Avatar
{
    public class Startup
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            var nationsBuilder = new NationsBuilder();

            while (command != "Quit")
            {
                var commandTokens = command.Split().ToList();
                var commandType = commandTokens[0];

                switch (commandType)
                {
                    case "Bender":
                        nationsBuilder.AssignBender(commandTokens);
                        break;
                    case "Monument":
                        nationsBuilder.AssignMonument(commandTokens);
                        break;
                    case "Status":
                        Console.WriteLine(nationsBuilder.GetStatus(commandTokens[1]));
                        break;
                    case "War":
                        nationsBuilder.IssueWar(commandTokens[1]);
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(nationsBuilder.GetWarsRecord());
        }
    }
}
