using System;

namespace OOP_Labb_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri geo;

            geo = new Cirkel();
            Console.WriteLine("Cirkel Area: {0}a.e", geo.Area());

            geo = new Fyrkant();
            Console.WriteLine("Fyrkant Area: {0}a.e", geo.Area());

            geo = new Rektangel();
            Console.WriteLine("Rektangel Area: {0}a.e", geo.Area());
        }
    }
}
