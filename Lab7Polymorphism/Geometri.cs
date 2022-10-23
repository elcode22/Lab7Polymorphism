using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Polymorphism
{
    abstract class Geometri
    {
        private double area;
        public virtual double Area() 
        {
            return area;
        }
    }
}
