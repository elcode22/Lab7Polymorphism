// Elias Hammou, NET22
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Polymorphism
{
    class Ellips:Geometri
    {
        private const double PI = 3.14;
        private double majorRadius;
        private double minorRadius;
        private double area;

        public Ellips(double majorRadius, double minorRadius) 
        {
            this.majorRadius = majorRadius;
            this.minorRadius = minorRadius;
        }

        public double MajorRadius => majorRadius;
        public double MinorRadius => minorRadius;

        public override double Area()
        {
            area = PI * majorRadius * minorRadius;
            return area;
        }
    }
}
