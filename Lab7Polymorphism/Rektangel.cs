using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Polymorphism
{
    class Rektangel:Geometri
    {
        private double length;
        private double height;
        private double area;

        public Rektangel(double length, double height) 
        {
            this.length = length;
            this.height = height;
        }

        public double Length
        {
            get { return length; }
        }
        
        public double Height 
        {
            get { return height; }
        }

        public override double Area()
        {
            area = length * height;
            return area;
        }
    }
}
