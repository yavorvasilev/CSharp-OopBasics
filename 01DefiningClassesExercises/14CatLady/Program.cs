namespace _14CatLady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var cats = new Dictionary<string, object>();
            var catInfo = Console.ReadLine();

            while (catInfo != "End")
            {
                var tokens = catInfo.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var typeOfCat = tokens[0];
                var name = tokens[1];
                var param = tokens[2];

                switch (typeOfCat)
                {
                    case "StreetExtraordinaire":
                        var catStreet = new StreetExtraordinaire(name, typeOfCat, param);
                        cats.Add(name, catStreet);
                        break;

                    case "Siamese":
                        var catSiam = new Siamese(name, typeOfCat, param);
                        cats.Add(name, catSiam);
                        break;

                    case "Cymric":
                        var catCymric = new Cymric(name, typeOfCat, param);
                        cats.Add(name, catCymric);
                        break;
                }

                catInfo = Console.ReadLine();
            }

            var catName = Console.ReadLine();

            Console.WriteLine(cats[catName]);
        }
    }
}
