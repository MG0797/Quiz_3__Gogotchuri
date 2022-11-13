using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    public class Trapezoid : IShape
    {

        private double base1;
        private double base2;
        private double leg1;
        private double leg2;
        private double height;

        public Trapezoid(double base1, double base2, double leg1, double leg2, double height)
        {
            this.base1 = base1;
            this.base2 = base2;
            this.leg1 = leg1;
            this.leg2 = leg2;
            this.height = height;
        }

        public double GetArea()
        {
           return ((base1+base2)/2)*height;
        }

        public double GetPerimeter()
        {
            return base1+base2+leg1+leg2;
        }
    }
}
