using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    public class Triangle : IShape
    {

        private double side1;
        private double side2;
        private double side3;
        private double height;
        private double baseside;

        public Triangle(double side1, double side2, double side3, double height, double baseside)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            this.height = height;
            this.baseside = baseside;
        }

        public double GetArea()
        {
            return 1/2*baseside*height;
        }

        public double GetPerimeter()
        {
            return side1+side2+side3;
        }
    }
}
