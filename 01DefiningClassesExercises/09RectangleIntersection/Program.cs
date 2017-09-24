using System;
using System.Collections.Generic;
using System.Linq;

namespace _09RectangleIntersection
{
    public class Program
    {
        public static void Main()
        {
            var rectangles = new Dictionary<string, Rectangle>();

            var firstLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var numberOfRectangle = firstLine.First();
            var numberOfChecks = firstLine.Last();

            for (int i = 0; i < numberOfRectangle; i++)
            {
                var rectangleInfo = Console.ReadLine().Split();
                var rectangle = new Rectangle(rectangleInfo[0], 
                    double.Parse(rectangleInfo[1]),
                    double.Parse(rectangleInfo[2]),
                    double.Parse(rectangleInfo[3]),
                    double.Parse(rectangleInfo[4])
                    );
                rectangles.Add(rectangleInfo[0], rectangle);
            }

            for (int i = 0; i < numberOfChecks; i++)
            {
                var check = Console.ReadLine().Split();
                var firstRec = rectangles[check[0]];
                var secondRec = rectangles[check[1]];
                Console.WriteLine(firstRec.CheckingIntersectRectangle(secondRec).ToString().ToLower());
            }
        }
    }
}
