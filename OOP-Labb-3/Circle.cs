using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace OOP_Labb_3
{
    internal class Circle : Geometry
    {
        protected double Radius { get; set; }

        public Circle() {
            this.Radius = 4;
        }

        public Circle(double radius) {
            this.Radius = radius;
        }

        public override double Area() => (Math.Pow(this.Radius, 2) * Math.PI);

    }
}
