using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_3
{
    internal class Rectangle : Geometry
    {
        protected double Width { get; set; }
        protected double Height { get; set; }

        public Rectangle()
        {
            this.Width = 4;
            this.Height = 8;
        }

        public Rectangle(double width, double height) {
            this.Width = width;
            this.Height = height;
        }

        public override double Area() => (this.Width * this.Height);
    }
}
