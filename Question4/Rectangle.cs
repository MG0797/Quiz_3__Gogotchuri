using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    public class Rectangle : IShape
    {

        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double GetArea()
        {
            return length*width;
        }

        public double GetPerimeter()
        {
            return 2*(length+width);
        }
    }
}
