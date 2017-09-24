using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minedraft
{
    public class Startup
    {
        public static void Main()
        {
            var manager = new DraftManager();
            var input = Console.ReadLine();

            while (input != "Shutdown")
            {
                var command = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .FirstOrDefault();
                var commandTokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (commandTokens.Count > 1)
                {
                    commandTokens.Remove(command);
                }
                

                try
                {
                    switch (command)
                    {
                        case "RegisterHarvester":
                            Console.WriteLine(manager.RegisterHarvester(commandTokens));
                            break;

                        case "RegisterProvider":
                            Console.WriteLine(manager.RegisterProvider(commandTokens));
                            break;

                        case "Day":
                            Console.WriteLine(manager.Day());
                            break;

                        case "Mode":
                            Console.WriteLine(manager.Mode(commandTokens));
                            break;

                        case "Check":
                            Console.WriteLine(manager.Check(commandTokens));
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(manager.ShutDown());
        }
    }
}
