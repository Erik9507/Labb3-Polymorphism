using System;               //Erik Norell Sut21
using System.Collections.Generic;
using System.Text;

namespace Labb3_Polymorphism
{
    public class Rektangel : Teckning    //child class
    {
        public double Bas{get; set;}
        public double Höjd {get; set;}

        public Rektangel()
        {
            Bas = 10;
            Höjd = 5;
        }
        public override double Area()
        {
            return Bas * Höjd;
        }


    }
}
