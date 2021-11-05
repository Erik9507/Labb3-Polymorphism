using System;               //Erik Norell Sut21
using System.Collections.Generic;
using System.Text;

namespace Labb3_Polymorphism
{
    public class Cirkel : Teckning   //child class
    {
        public double Radie { get; set; }
        public double Pi = 3.14;
        public Cirkel()
        {
            Radie = 8;
        }
        public override double Area()
        {
            return (Radie * Radie) * Pi;
        }

    }
}
