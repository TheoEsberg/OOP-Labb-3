using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_3
{
    internal class Square : Geometry
    {
        protected double Width { get; set; }

        public Square()
        {
            this.Width = 4;
        }

        public Square(double width) {
            this.Width = width;
        }

        public override double Area() => (this.Width * this.Width);

    }
}
