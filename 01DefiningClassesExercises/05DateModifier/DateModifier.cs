namespace _05DateModifier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DateModifier
    {
        public double differenceOfTheDays;

        public void DifferenceOfTheDays(string firstDate, string secondDate)
        {
            var dateOne = DateTime.Parse(firstDate);
            var dateTwo = DateTime.Parse(secondDate);
            var diff = Math.Abs((dateOne - dateTwo).TotalDays);
            this.differenceOfTheDays = diff;
        }
    }
}
