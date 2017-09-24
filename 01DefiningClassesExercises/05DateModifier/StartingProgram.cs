namespace _05DateModifier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartingProgram
    {
        public static void Main()
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            var differenceOfTheDates = new DateModifier();
            differenceOfTheDates.DifferenceOfTheDays(firstDate, secondDate);

            Console.WriteLine(differenceOfTheDates.differenceOfTheDays);
        }
    }
}
