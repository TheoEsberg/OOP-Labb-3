using System;

namespace OOP_Labb_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry geo;

            geo = new Circle();
            Console.WriteLine("Cirkel Area: {0}a.e", geo.Area());

            geo = new Square();
            Console.WriteLine("Fyrkant Area: {0}a.e", geo.Area());

            geo = new Rectangle();
            Console.WriteLine("Rektangel Area: {0}a.e", geo.Area());
        }
    }
}
