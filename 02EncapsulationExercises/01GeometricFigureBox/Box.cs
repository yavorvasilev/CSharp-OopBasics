using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01GeometricFigureBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get
            {
                return this.length;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }

        
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }


        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double GetSurfaceArea()
        {
            var surfaceArea = 2 * this.length * this.width +
                2 * this.length * this.height +
                2 * this.width * this.height;

            return surfaceArea;
        }

        public double GetLateralSurface()
        {
            var lateralSurfaceArea = 2 * this.length * this.height +
                2 * this.width * this.height;

            return lateralSurfaceArea;
        }

        public double GetVolume()
        {
            var volume = this.length * this.height * this.width;

            return volume;
        }

    }
}
