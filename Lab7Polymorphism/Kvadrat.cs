using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Polymorphism
{
    class Kvadrat:Geometri
    {
        private double side;
        private double area;
        public Kvadrat(double side) 
        {
            this.side = side;
        }
        public double Side 
        {
            get { return side; }
        }

        public override double Area() 
        {
            area = Math.Pow(side, 2);
            return area;
        }
    }
}
