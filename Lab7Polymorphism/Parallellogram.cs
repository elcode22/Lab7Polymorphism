using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Polymorphism
{
    class Parallellogram:Geometri
    {
        private double heigth;
        private double length;
        private double area;

        public Parallellogram(double heigth, double length) 
        {
            this.heigth = heigth;
            this.length = length;
        }

        public double Height => heigth;
        public double Length => length;

        public override double Area() 
        {
            area = Height * length;
            return area;
        }
    }
}
