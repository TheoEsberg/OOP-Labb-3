using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_3
{
    internal class Fyrkant : Geometri
    {
        protected double Width { get; set; }

        public Fyrkant()
        {
            this.Width = 4;
        }

        public Fyrkant(double width) {
            this.Width = width;
        }

        public override double Area() => (this.Width * this.Width);

    }
}
