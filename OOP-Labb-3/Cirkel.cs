using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace OOP_Labb_3
{
    internal class Cirkel : Geometri
    {
        protected double Radius { get; set; }

        public Cirkel() {
            this.Radius = 4;
        }

        public Cirkel(double radius) {
            this.Radius = radius;
        }

        public override double Area() => (Math.Pow(this.Radius, 2) * Math.PI);

    }
}
