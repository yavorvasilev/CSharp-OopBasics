using System;
using System.Linq;
using System.Reflection;

namespace _01GeometricFigureBox
{
    public class Program
    {
        static void Main(string[] args)
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            try
            {
                var length = double.Parse(Console.ReadLine());
                var width = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());

                var figure = new Box(length, width, height);


                Console.WriteLine($"Surface Area - {figure.GetSurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {figure.GetLateralSurface():f2}");
                Console.WriteLine($"Volume - {figure.GetVolume():f2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         
        }
    }
}
