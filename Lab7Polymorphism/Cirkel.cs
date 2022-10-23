using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Polymorphism
{
    class Cirkel:Geometri
    {
        private const double PI = 3.14;
        private double radius;
        private double diameter;
        private double area;

        public Cirkel(double radius) 
        {
            this.radius = radius;
        }

        public double Radius => radius;

        public override double Area() 
        {
            diameter = radius * 2;
            area = (PI * Math.Pow(diameter, 2)) / 4;
            return area;
        }
    }
}
